using System;

namespace _1_Variablen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Simple "Hello World"
            Console.WriteLine("Hello World!");

            // 2. Declaration of a normal variable
            int age = 25; // whole-number variable
            Console.WriteLine($"Alter: {age}");

            // 3. Declaration of a string-variable
            string name = "Lucas"; // Text Variable
            Console.WriteLine($"Name: {name}");

            // 4. Declaration of a constant
            const double pi = 3.14159; // constants are fixed and not changeable
            Console.WriteLine($"Pi: {pi}");

            // 5. Nullable variable (mit ?)
            int? nullableAge = null; // Nullable int (can be null)
            Console.WriteLine($"Nullable Alter: {(nullableAge.HasValue ? nullableAge.Value.ToString() : "unbekannt")}");

            // Assignment of a value to nullableAge
            nullableAge = 24;
            Console.WriteLine($"Nullable Alter mit Wert: {nullableAge}");

            // 6. Boolean-variable
            bool isStudent = false; // Truth-conditional-value (true/false)
            Console.WriteLine($"Ist Student: {isStudent}");

            // 7. Floating-Point number (float and double)
            float height = 1.87f; // Floating-Point number with 'f' for Float
            double weight = 75.8; // Floating-Point number (higher precision)
            Console.WriteLine($"Größe: {height:F2} Meter");
            Console.WriteLine($"Gewicht: {weight:F1} kg");

            // Specialties for float: Rounding errors
            float floatCalc = 0.1f + 0.2f;
            Console.WriteLine($"Float Rundung: 0.1 + 0.2 = {floatCalc} (Erwartung: 0.3)");

            // Specialties for double: higher precision
            double doubleCalc = 0.1 + 0.2;
            Console.WriteLine($"Double Präzision: 0.1 + 0.2 = {doubleCalc}");

            // 8. Typeconversion
            Console.WriteLine("\n8. Typkonvertierungen:");

            // a) implicit conversion (a.e. int to double)
            double implicitConversion = age;
            Console.WriteLine($"Implizite Konvertierung von int zu double: {implicitConversion}");

            // b) explicit conversion (a.e. double to int)
            int explicitConversion = (int)weight;
            Console.WriteLine($"Explizite Konvertierung von double zu int (Gewicht): {explicitConversion}");

            // c) String to Number
            string strNumber = "42";
            int parsedNumber = int.Parse(strNumber);
            Console.WriteLine($"String zu Zahl mit Parse: {parsedNumber}");

            // d) Number to String
            string numberAsString = age.ToString();
            Console.WriteLine($"Zahl zu String mit ToString(): {numberAsString}");

            // e) safe converting with TryParse
            string invalidNumber = "abc";
            if (int.TryParse(invalidNumber, out int result))
            {
                Console.WriteLine($"Erfolgreich konvertiert: {result}");
            }
            else
            {
                Console.WriteLine($"Fehler beim Konvertieren von '{invalidNumber}' zu int.");
            }

            // 9. formatting
            Console.WriteLine("\n9. Formatierungen:");

            // a) number formatting
            double price = 12345.6789;
            Console.WriteLine($"Preis (Standard): {price}");
            Console.WriteLine($"Preis (2 Dezimalstellen): {price:F2}");
            Console.WriteLine($"Preis (Währung): {price:C}");

            // b) Numbers with thousands delimiter
            int largeNumber = 1000000;
            Console.WriteLine($"Große Zahl mit Tausendertrennzeichen: {largeNumber:N0}");

            // c) date-formating
            DateTime today = DateTime.Now;
            Console.WriteLine($"Aktuelles Datum (kurz): {today:d}");
            Console.WriteLine($"Aktuelles Datum (lang): {today:D}");
            Console.WriteLine($"Uhrzeit: {today:T}");

            // 10. Working with Strings: Split, Join, Search, interpolated Strings
            Console.WriteLine("\n10. Arbeiten mit Strings:");

            string sentence = "Das ist ein Beispiel für eine Zeichenkette.";
            Console.WriteLine($"Originaler Satz: {sentence}");

            // Split
            string[] words = sentence.Split(' ');
            Console.WriteLine("Gesplittete Wörter:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Join
            string joinedSentence = string.Join(", ", words);
            Console.WriteLine($"Wieder zusammengesetzt (mit Komma): {joinedSentence}");

            // Search
            string searchWord = "Beispiel";
            Console.WriteLine(sentence.Contains(searchWord)
                ? $"Das Wort '{searchWord}' wurde gefunden."
                : $"Das Wort '{searchWord}' wurde nicht gefunden.");

            // interpolated Strings
            int apples = 5;
            int bananas = 3;
            Console.WriteLine($"Ich habe {apples} Äpfel und {bananas} Bananen. Insgesamt: {apples + bananas} Früchte.");

            // Finish
            Console.WriteLine("\nProgramm beendet.");
        }
    }
}
