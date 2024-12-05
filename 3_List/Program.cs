namespace _3_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Creation of a List
            List<string> names = new List<string> { "Lucas", "Tom", "Thomas" };
            Console.WriteLine("1. Ursprungsliste:");
            PrintList(names);

            // 2. Adding an Element
            names.Add("Alois");
            Console.WriteLine("\n2. Nach Hinzufügen eines Elements (Alois):");
            PrintList(names);

            // 3. Removal of an Element
            names.Remove("Lucas");
            Console.WriteLine("\n3. Nach Entfernen eines Elements (Lucas):");
            PrintList(names);

            // 4. Access of an element via Index 
            Console.WriteLine("\n4. Zugriff auf ein Element per Index:");
            Console.WriteLine($"Das erste Element ist: {names[0]}");

            // 5. Checking if an element exists 
            Console.WriteLine("\n5. Überprüfung, ob ein Element existiert:");
            string searchName = "Andy";
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} ist in der Liste.");
            }
            else
            {
                Console.WriteLine($"{searchName} ist nicht in der Liste.");
            }

            // 6. Adding an element at a specific position 
            names.Insert(1, "Frank");
            Console.WriteLine("\n6. Nach Einfügen eines Elements (Frank) an Position 1:");
            PrintList(names);

            // 7. sorting the list
            names.Sort();
            Console.WriteLine("\n7. Nach Sortieren der Liste:");
            PrintList(names);

            // 8. reverse the list 
            names.Reverse();
            Console.WriteLine("\n8. Nach Umkehren der Liste:");
            PrintList(names);

            // 9. list with numbers (generic list)
            List<int> numbers = new List<int> { 5, 3, 8, 1, 2 };
            Console.WriteLine("\n9. Zahlenliste vor Sortieren:");
            PrintList(numbers);

            numbers.Sort();
            Console.WriteLine("Zahlenliste nach Sortieren:");
            PrintList(numbers);

            // 10. Iterating through the list with foreach 
            Console.WriteLine("\n10. Iteration über die Liste mit foreach:");
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
