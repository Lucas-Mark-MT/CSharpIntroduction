namespace _6_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Erstellung eines IEnumerable mit einer Liste
            IEnumerable<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            Console.WriteLine("1. IEnumerable basierend auf einer Liste:");
            PrintEnumerable(numbers);

            // 2. Erstellung eines IEnumerable mit einem Array
            IEnumerable<string> names = new string[] { "Lucas", "Tom", "Thomas" };
            Console.WriteLine("\n2. IEnumerable basierend auf einem Array:");
            PrintEnumerable(names);

            // 3. Iteration über IEnumerable mit foreach
            Console.WriteLine("\n3. Iteration über IEnumerable mit foreach:");
            foreach (var number in numbers)
            {
                Console.WriteLine($"Wert: {number}");
            }

            // 4. Manuelle Iteration mit IEnumerator
            Console.WriteLine("\n4. Manuelle Iteration mit IEnumerator:");
            using (var enumerator = numbers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine($"Wert: {enumerator.Current}");
                }
            }

            // 5. Filterung mit LINQ (ohne Bibliothek nur demonstrativ für IEnumerable)
            Console.WriteLine("\n5. Filterung (manuell nach Werten größer als 20):");
            IEnumerable<int> filteredNumbers = FilterGreaterThan(numbers, 20);
            PrintEnumerable(filteredNumbers);

            // 6. Lazy Evaluation mit einem Iterator (yield return)
            Console.WriteLine("\n6. Lazy Evaluation (Iterator mit yield return):");
            IEnumerable<int> lazyNumbers = LazyNumbers();
            foreach (var num in lazyNumbers)
            {
                if (num > 3) break; // Demonstration der Lazy Evaluation
                Console.WriteLine($"Wert: {num}");
            }
        }

        // Hilfsmethode zum Drucken eines IEnumerable
        static void PrintEnumerable<T>(IEnumerable<T> enumerable)
        {
            Console.WriteLine("[ " + string.Join(", ", enumerable) + " ]");
        }

        // Filtermethode für IEnumerable (ohne LINQ)
        static IEnumerable<int> FilterGreaterThan(IEnumerable<int> source, int threshold)
        {
            foreach (var item in source)
            {
                if (item > threshold)
                {
                    yield return item;
                }
            }
        }

        // Lazy Iterator mit yield return
        static IEnumerable<int> LazyNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
        }
    }
}

