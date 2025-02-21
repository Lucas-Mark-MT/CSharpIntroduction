namespace _2_for_and_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. simple counter loop
            Console.WriteLine("1. Einfache Zählerschleife:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Index: {i}");
            }

            // 2. counter loop with stepwidth
            Console.WriteLine("\n2. Zählerschleife mit Schrittweite:");
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine($"Index (Schrittweite 2): {i}");
            }

            // 3. descending loop
            Console.WriteLine("\n3. Absteigende Schleife:");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Absteigend: {i}");
            }

            // 4. Multiple variables in a loop
            Console.WriteLine("\n4. Mehrere Variablen in einer Schleife:");
            for (int i = 0, j = 10; i <= 10; i++, j--)
            {
                Console.WriteLine($"i: {i}, j: {j}");
            }

            // 5. never ending loop(with break)
            Console.WriteLine("\n5. Unendliche Schleife:");
            for (; ; )
            {
                Console.WriteLine("Unendliche Schleife (beendet mit break)");
                break;
            }

            // 6. `for` with dynamic condition
            Console.WriteLine("\n6. `for` mit dynamischer Bedingung:");
            int limit = new Random().Next(1, 10);
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine($"Dynamisches Limit: {i}");
            }

            // 7. Loop with empty scope
            Console.WriteLine("\n7. Schleife mit leerem Block:");
            for (int i = 0; i < 5; i++) ;
            Console.WriteLine("Schleife ohne Inhalt, nur mit Iteration.");

            // 8. foreach through an array 
            Console.WriteLine("\n8. `foreach` über ein Array:");
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // 9. iterating through an list
            Console.WriteLine("\n9. Iteration über eine Liste:");
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // 10. iterating through an char in a char sequence
            Console.WriteLine("\n10. Iteration über Zeichen einer Zeichenkette:");
            string text = "Hello";
            foreach (char c in text)
            {
                Console.WriteLine(c);
            }

            // 11. iterating with key-value-pairs in dictionaries
            Console.WriteLine("\n11. Iteration mit Key-Value-Pairs in Dictionaries:");
            var dictionary = new Dictionary<string, int>
        {
            { "Alice", 30 },
            { "Bob", 25 }
        };
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // 12. iterating with index(via `Select`)
            Console.WriteLine("\n12. Iteration mit Index (via `Select`):");
            var items = new[] { "A", "B", "C" };
            foreach (var (item, index) in items.Select((item, index) => (item, index)))
            {
                Console.WriteLine($"Index: {index}, Item: {item}");
            }

            // 13. `foreach` with break and continue
            Console.WriteLine("\n13. `foreach` mit break und continue:");
            int[] moreNumbers = { 1, 2, 3, 4, 5 };
            int[] evenMoreNumbers = new int[] { 1,2,3,4,5};

            foreach (int number in moreNumbers)
            {
                if (number == 3) continue; // 3 skip
                if (number == 5) break;    // end loop
                Console.WriteLine(number);
            }
       
        }

      }
}

