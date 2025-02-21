namespace _4_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Creation and initialization of an array
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("1. Original array:");
            PrintArray(numbers);

            // 2. Accessing an element through indexing
            Console.WriteLine("\n2. Accessing elements:");
            Console.WriteLine($"The first element is: {numbers[0]}");
            Console.WriteLine($"The last element is: {numbers[numbers.Length - 1]}");

            // 3. Changing an element
            numbers[2] = 99; // Set the third element to 99 (always remember: arrays are 0-indexed)
            Console.WriteLine("\n3. After modifying an element (3rd element = 99):");
            PrintArray(numbers);

            // 4. Iterating through an array with a for-loop
            Console.WriteLine("\n4. Iteration with a for-loop:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }

            // 5. Iterating through an array with foreach
            Console.WriteLine("\n5. Iteration with foreach:");
            foreach (int number in numbers)
            {
                Console.WriteLine($"Value: {number}");
            }

            // 6. Multidimensional array
            int[,] matrix = {
                { 1, 2, 3},
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 9, 10, 11 }
            };
            Console.WriteLine("\n6. Multidimensional array (Matrix):");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            // 7. Array with strings
            string[] names = { "Tom", "Lucas", "Thomas" };
            Console.WriteLine("\n7. Array with strings:");
            PrintArray(names);

            // 8. Array methods (sorting)
            Array.Sort(numbers);
            Console.WriteLine("\n8. Sorted array:");
            PrintArray(numbers);

            // 9. Array length
            Console.WriteLine("\n9. Length of the array:");
            Console.WriteLine($"The array contains {numbers.Length} elements.");

            var intarr = new int[5];
            const int BufferSize = 5;
            for (int index = 0; index < BufferSize; index++)
            {
                intarr[index % BufferSize] = 0;
                Console.WriteLine(index % BufferSize);
            }

        }

        // Helper method to print arrays 
        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("[ " + string.Join(", ", array) + " ]");
        }
    }
}
