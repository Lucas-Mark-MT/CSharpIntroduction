namespace _6_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Creating an IEnumerable with a List
            IEnumerable<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            Console.WriteLine("1. IEnumerable based on a List:");
            PrintEnumerable(numbers);

            // 2. Creating an IEnumerable with an Array
            IEnumerable<string> names = new string[] { "Lucas", "Tom", "Thomas" };
            Console.WriteLine("\n2. IEnumerable based on an Array:");
            PrintEnumerable(names);

            // 3. Iterating over IEnumerable with foreach
            Console.WriteLine("\n3. Iterating over IEnumerable with foreach:");
            foreach (var number in numbers)
            {
                Console.WriteLine($"Value: {number}");
            }

            // 4. Manual Iteration with IEnumerator
            Console.WriteLine("\n4. Manual Iteration with IEnumerator:");
            using (var enumerator = numbers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine($"Value: {enumerator.Current}");
                }
            }

            // 5. Filtering with LINQ (manually filtering IEnumerable without LINQ)
            Console.WriteLine("\n5. Filtering (manually filtering values greater than 20):");
            IEnumerable<int> filteredNumbers = FilterGreaterThan(numbers, 20);
            PrintEnumerable(filteredNumbers);

            // 6. Lazy Evaluation with an Iterator (yield return)
            Console.WriteLine("\n6. Lazy Evaluation (Iterator with yield return):");
            IEnumerable<int> lazyNumbers = LazyNumbers();
            foreach (var num in lazyNumbers)
            {
                if (num > 3) break; // Demonstrating Lazy Evaluation
                Console.WriteLine($"Value: {num}");
            }
        }

        // Helper method to print an IEnumerable
        static void PrintEnumerable<T>(IEnumerable<T> enumerable)
        {
            Console.WriteLine("[ " + string.Join(", ", enumerable) + " ]");
        }

        // Filtering method for IEnumerable (without LINQ)
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

        // Lazy Iterator with yield return
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
