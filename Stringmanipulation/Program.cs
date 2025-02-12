using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String-Manipulation in C#");

            // 1. Splitting Strings
            string text = "Das ist ein Test. Hier kommt noch ein Satz.";
            string[] satzteile = text.Split('.');
            Console.WriteLine("\nGetrennte Sätze:");
            foreach (var teil in satzteile)
            {
                Console.WriteLine(teil.Trim());
            }

            // 2. Join Strings
            string[] worte = { "C#", "ist", "eine", "tolle", "Sprache" };
            string zusammengefügt = string.Join(" ", worte);
            Console.WriteLine($"\nZusammengefügter Satz: {zusammengefügt}");

            // 3. Search chain of chars
            string suchwort = "tolle";
            if (zusammengefügt.Contains(suchwort))
            {
                Console.WriteLine($"\nDas Wort '{suchwort}' wurde gefunden!");
            }
            else
            {
                Console.WriteLine($"\nDas Wort '{suchwort}' wurde nicht gefunden.");
            }

            // 4. Search and replace chars
            string rawText = "C# ist super!!!";
            string cleanText = rawText.Replace("!!!", "").Replace("super", "fantastisch");
            Console.WriteLine($"\nBereinigter Text: {cleanText}");

            // 5. String analysis (length, starts with, ends with)
            Console.WriteLine($"\nLänge des Textes: {cleanText.Length}");
            Console.WriteLine(cleanText.StartsWith("C#") ? "Der Text beginnt mit 'C#'." : "Der Text beginnt nicht mit 'C#'.");
            Console.WriteLine(cleanText.EndsWith("tisch") ? "Der Text endet mit 'tisch'." : "Der Text endet nicht mit 'tisch'.");

            // 6. filtering words from a sentence
            string[] langeWorte = zusammengefügt.Split(' ');
            var gefilterteWorte = Array.FindAll(langeWorte, w => w.Length > 3);
            Console.WriteLine("\nWörter mit mehr als 3 Buchstaben:");
            foreach (var wort in gefilterteWorte)
            {
                Console.WriteLine(wort);
            }

            // 7. Substring and IndexOf
            string langText = "Die Programmiersprache C# ist sehr leistungsstark.";
            int index = langText.IndexOf("C#");
            Console.WriteLine($"\n'C#' beginnt an Index {index}");
            if (index >= 0)
            {
                string substring = langText.Substring(index, 2);
                Console.WriteLine($"Substring extrahiert: {substring}");
            }

            Console.WriteLine("\nProgramm beendet.");
        }
    }
}
