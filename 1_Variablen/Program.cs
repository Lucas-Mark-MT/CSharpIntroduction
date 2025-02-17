using System;

namespace _1_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Simple "Hello World"
            Console.WriteLine("Hello World!");

            // 2. Declaration of a normal variable
            int age = 25; // whole-number variable
            Console.WriteLine($"Age: {age}");

            // 3. Declaration of a string variable
            string name = "Lucas"; // Text variable
            Console.WriteLine($"Name: {name}");

            // 4. Declaration of a constant
            const double pi = 3.14159; // constants are fixed and not changeable
            Console.WriteLine($"Pi: {pi}");

            // 5. Nullable variable (with ?)
            int? nullableAge = null; // Nullable int (can be null)
            Console.WriteLine($"Nullable Age: {(nullableAge.HasValue ? nullableAge.Value.ToString() : "unknown")}");

            // Assignment of a value to nullableAge
            nullableAge = 24;
            Console.WriteLine($"Nullable Age with value: {nullableAge}");

            // 6. Boolean variable
            bool isStudent = false; // Truth-conditional value (true/false)
            Console.WriteLine($"Is Student: {isStudent}");

            // 7. Floating-Point numbers (float and double)
            float height = 1.87f; // Floating-Point number with 'f' for Float
            double weight = 75.8; // Floating-Point number (higher precision)
            Console.WriteLine($"Height: {height:F2} meters");
            Console.WriteLine($"Weight: {weight:F1} kg");

            // Specialties for float: Rounding errors
            float floatCalc = 0.1f + 0.2f;
            Console.WriteLine($"Float rounding: 0.1 + 0.2 = {floatCalc} (Expected: 0.3)");

            // Specialties for double: higher precision
            double doubleCalc = 0.1 + 0.2;
            Console.WriteLine($"Double precision: 0.1 + 0.2 = {doubleCalc}");

            // 8. Type conversion
            Console.WriteLine("\n8. Type Conversions:");

            // a) implicit conversion (e.g., int to double)
            double implicitConversion = age;
            Console.WriteLine($"Implicit conversion from int to double: {implicitConversion}");

            // b) explicit conversion (e.g., double to int)
            int explicitConversion = (int)weight;
            Console.WriteLine($"Explicit conversion from double to int (Weight): {explicitConversion}");

            // c) String to Number
            string strNumber = "42";
            int parsedNumber = int.Parse(strNumber);
            Console.WriteLine($"String to number with Parse: {parsedNumber}");

            // d) Number to String
            string numberAsString = age.ToString();
            Console.WriteLine($"Number to String with ToString(): {numberAsString}");

            // e) safe converting with TryParse
            string invalidNumber = "abc";
            if (int.TryParse(invalidNumber, out int result))
            {
                Console.WriteLine($"Successfully converted: {result}");
            }
            else
            {
                Console.WriteLine($"Error converting '{invalidNumber}' to int.");
            }

            // 9. Formatting
            Console.WriteLine("\n9. Formatting:");

            // a) number formatting
            double price = 12345.6789;
            Console.WriteLine($"Price (Standard): {price}");
            Console.WriteLine($"Price (2 decimal places): {price:F2}");
            Console.WriteLine($"Price (Currency): {price:C}");

            // b) Numbers with thousands delimiter
            int largeNumber = 1000000;
            Console.WriteLine($"Large number with thousands separator: {largeNumber:N0}");

            // c) date formatting
            DateTime today = DateTime.Now;
            Console.WriteLine($"Current date (short): {today:d}");
            Console.WriteLine($"Current date (long): {today:D}");
            Console.WriteLine($"Time: {today:T}");

            // 10. Working with Strings: Split, Join, Search, Interpolated Strings
            Console.WriteLine("\n10. Working with Strings:");

            string sentence = "This is an example of a string.";
            Console.WriteLine($"Original sentence: {sentence}");

            // Split
            string[] words = sentence.Split(' ');
            Console.WriteLine("Split words:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Join
            string joinedSentence = string.Join(", ", words);
            Console.WriteLine($"Rejoined (with comma): {joinedSentence}");

            // Search
            string searchWord = "example";
            Console.WriteLine(sentence.Contains(searchWord)
                ? $"The word '{searchWord}' was found."
                : $"The word '{searchWord}' was not found.");

            // Interpolated strings
            int apples = 5;
            int bananas = 3;
            Console.WriteLine($"I have {apples} apples and {bananas} bananas. In total: {apples + bananas} fruits.");

            // Finish
            Console.WriteLine("\nProgram finished.");
        }
    }
}
