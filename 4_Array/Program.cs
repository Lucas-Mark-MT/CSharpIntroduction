namespace _4_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Creation and initialisation of an array
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("1. Ursprüngliches Array:");
            PrintArray(numbers);

            // 2.Access of an element through indexing
            Console.WriteLine("\n2. Zugriff auf Elemente:");
            Console.WriteLine($"Das erste Element ist: {numbers[0]}");
            Console.WriteLine($"Das letzte Element ist: {numbers[numbers.Length - 1]}");

            // 3. Changing of an element
            numbers[2] = 99; // Set the third element to 99 (always remember: Arrays are 0-indexed)
            Console.WriteLine("\n3. Nach Änderung eines Elements (3. Element = 99):");
            PrintArray(numbers);

            // 4. Iteration through an array with a for-loop 
            Console.WriteLine("\n4. Iteration mit einer for-Schleife:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }

            // 5. Iteration through an array with foreach
            Console.WriteLine("\n5. Iteration mit foreach:");
            foreach (int number in numbers)
            {
                Console.WriteLine($"Wert: {number}");
            }

            // 6. multidimensional Array
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            Console.WriteLine("\n6. Mehrdimensionales Array (Matrix):");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            // 7. Array with Strings
            string[] names = { "Tom", "Lucas", "Thomas" };
            Console.WriteLine("\n7. Array mit Strings:");
            PrintArray(names);

            // 8. Array-methods(sorting)
            Array.Sort(numbers);
            Console.WriteLine("\n8. Array sortiert:");
            PrintArray(numbers);

            // 9. Array-length
            Console.WriteLine("\n9. Länge des Arrays:");
            Console.WriteLine($"Das Array enthält {numbers.Length} Elemente.");
        }

        // Helpermethod to print arrays 
        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("[ " + string.Join(", ", array) + " ]");
        }
    }
}

