namespace _10_Get_Set
{
    internal class Program
    {
        public class Age
        {
            private int _newAge; // Private backing field

            public int InitialAge { get; set; } // Auto-property

            public int NewAge
            {
                set { Set(value); } // Calls the predefined `Set` method
                get { return _newAge; } // Returns the backing field
            }

            // Predefined Set method
            public void Set(int value)
            {
                // Logic for setting the new age
                if (value < 0)
                {
                    _newAge = 0; // Prevent negative ages
                    Console.WriteLine("Age cannot be negative. Setting to 0.");
                }
                else
                {
                    _newAge = value;
                }
            }
        }

        static void Main(string[] args)
        {
            var person = new Age { InitialAge = 25 }; // Set InitialAge
            Console.WriteLine($"Initial Age: {person.InitialAge}");

            // Use the predefined Set method via the property
            person.NewAge = 30;
            Console.WriteLine($"New Age: {person.NewAge}");

            // Try setting a negative age
            person.NewAge = -5;
            Console.WriteLine($"New Age after invalid input: {person.NewAge}");
        }
    }
}
