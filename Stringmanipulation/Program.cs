using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Manipulation in C#");

            // 1. Splitting Strings
            string text = "This is a test. Here comes another sentence.";
            string[] sentenceParts = text.Split('.', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Separated sentences:");
            foreach (var part in sentenceParts)
            {
                Console.WriteLine(part.Trim());
            }


           
            // 2. Joining Strings
            string[] words = { "C#", "is", "a", "great", "language" };
            string joinedSentence = string.Join(" ", words);
            Console.WriteLine($"Joined sentence: {joinedSentence}");

            // 3. Searching for a sequence of characters
            string searchWord = "great";
            if (joinedSentence.Contains(searchWord))
            {
                Console.WriteLine($"The word '{searchWord}' was found!");
            }
            else
            {
                Console.WriteLine($"The word '{searchWord}' was not found.");
            }

            // 4. Search and replace characters
            string rawText = "C# is awesome!!!";
            string cleanText = rawText.Replace("!!!", "").Replace("awesome", "fantastic");
            Console.WriteLine($"Cleaned text: {cleanText}");

            // 5. String analysis (length, starts with, ends with)
            Console.WriteLine($"Length of the text: {cleanText.Length}");
            Console.WriteLine(cleanText.StartsWith("C#", StringComparison.OrdinalIgnoreCase) ? "The text starts with 'C#'." : "The text does not start with 'C#'.");
            Console.WriteLine(cleanText.EndsWith("tic") ? "The text ends with 'tic'." : "The text does not end with 'tic'.");

            // 6. Filtering words from a sentence
            string[] longWords = joinedSentence.Split(' ');
            var filteredWords = Array.FindAll(longWords, w => w.Length > 3);
            Console.WriteLine("Words with more than 3 letters:");
            foreach (var word in filteredWords)
            {
                Console.WriteLine(word);
            }

            // 7. Substring and IndexOf
            string longText = "The programming language F# is very powerful.";
            int index = longText.IndexOf("C#");
            Console.WriteLine($"'C#' starts at index {index}");
            if (index >= 0)
            {
                string substring = longText.Substring(index, 2);
                Console.WriteLine($"Extracted substring: {substring}");
            }

            Console.WriteLine("Program finished.");
        }
    }
}
