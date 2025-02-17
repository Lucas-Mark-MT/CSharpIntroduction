namespace _5_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Creation of a List
            List<string> names = new List<string> { "Lucas", "Tom", "Thomas" };
            Console.WriteLine("1. Original list:");
            PrintList(names);

            // 2. Adding an element
            names.Add("Alois");
            Console.WriteLine("\n2. After adding an element (Alois):");
            PrintList(names);

            // 3. Removal of an element
            names.Remove("Lucas");
            Console.WriteLine("\n3. After removing an element (Lucas):");
            PrintList(names);

            // 4. Accessing an element via index 
            Console.WriteLine("\n4. Accessing an element by index:");
            Console.WriteLine($"The first element is: {names[0]}");

            // 5. Checking if an element exists 
            Console.WriteLine("\n5. Checking if an element exists:");
            string searchName = "Andy";
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }

            // 6. Adding an element at a specific position 
            names.Insert(1, "Frank");
            Console.WriteLine("\n6. After inserting an element (Frank) at position 1:");
            PrintList(names);

            // 7. Sorting the list
            names.Sort();
            Console.WriteLine("\n7. After sorting the list:");
            PrintList(names);

            // 8. Reversing the list 
            names.Reverse();
            Console.WriteLine("\n8. After reversing the list:");
            PrintList(names);

            // 9. List with numbers (generic list)
            List<int> numbers = new List<int> { 5, 3, 8, 1, 2 };
            Console.WriteLine("\n9. Number list before sorting:");
            PrintList(numbers);

            numbers.Sort();
            Console.WriteLine("Number list after sorting:");
            PrintList(numbers);

            // 10. Iterating through the list with foreach 
            Console.WriteLine("\n10. Iterating through the list with foreach:");
            foreach (var name in names)
            {
                Console.WriteLine($"Name: {name}");
            }

            static void PrintList<T>(List<T> list)
            {
                Console.WriteLine($"[ {string.Join(", ", list)} ]");
            }
        }
    }
}
