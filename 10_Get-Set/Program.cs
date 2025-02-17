namespace _10_Get_Set
{
    internal class Program
    {
        // Age class with properties for storing age values
        public class Age
        {
            private int _newAge; // Private backing field for the NewAge property

            public int InitialAge { get; set; } // Auto-property for InitialAge

            public int NewAge
            {
                set { Set(value); } // Calls the predefined Set method to set the value
                get { return _newAge; } // Returns the backing field _newAge
            }

            // Predefined Set method for validating and setting the age
            public void Set(int value)
            {
                // Logic to prevent negative age values
                if (value < 0)
                {
                    _newAge = 0; // Set age to 0 if the value is negative
                    Console.WriteLine("Age cannot be negative. Setting to 0.");
                }
                else
                {
                    _newAge = value; // Set the new valid age
                }
            }
        }

        // Main program to demonstrate the usage of the Age class
        static void Main(string[] args)
        {
            var person = new Age { InitialAge = 25 }; // Set the InitialAge property
            Console.WriteLine($"Initial Age: {person.InitialAge}");

            // Use the Set method to assign a new valid age via the NewAge property
            person.NewAge = 30;
            Console.WriteLine($"New Age: {person.NewAge}");

            // Try to set a negative age, triggering validation
            person.NewAge = -5;
            Console.WriteLine($"New Age after invalid input: {person.NewAge}");
        }
    }
}
