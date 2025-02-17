namespace _7_Enum
{
    internal class Program
    {
        // 1. Enum Declaration
        enum DayOfWeek
        {
            Monday,    // By default, values start at 0
            Tuesday,   // 1
            Wednesday, // 2
            Thursday,  // 3
            Friday,    // 4
            Saturday,  // 5
            Sunday     // 6
        }

        enum OrderStatus
        {
            Pending = 1,   // Manually assigned values
            Shipped = 2,
            Delivered = 3,
            Cancelled = 4
        }

        static void Main(string[] args)
        {
            // 2. Using Enums
            Console.WriteLine("1. Displaying an Enum value:");
            DayOfWeek today = DayOfWeek.Friday;
            Console.WriteLine($"Today is: {today}");

            // 3. Convert Enum to Integer
            Console.WriteLine("\n2. Enum value as an Integer:");
            int numericValue = (int)today;
            Console.WriteLine($"The numeric value of {today} is: {numericValue}");

            // 4. Convert Integer back to Enum
            Console.WriteLine("\n3. Converting an Integer to Enum:");
            DayOfWeek convertedDay = (DayOfWeek)4;
            Console.WriteLine($"The integer 4 corresponds to: {convertedDay}");

            // 5. Iterating over Enum values
            Console.WriteLine("\n4. Iterating through all Enum values:");
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine($"Day: {day} (Numeric Value: {(int)day})");
            }

            // 6. Enum with Custom Values
            Console.WriteLine("\n5. Enum with Custom Values:");
            OrderStatus status = OrderStatus.Shipped;
            Console.WriteLine($"The order status is: {status} (Numeric Value: {(int)status})");

            // 7. Convert Enum to String
            Console.WriteLine("\n6. Converting Enum Value to String:");
            string statusString = status.ToString();
            Console.WriteLine($"The status as a string: {statusString}");

            // 8. Convert String to Enum
            Console.WriteLine("\n7. Converting String to Enum:");
            if (Enum.TryParse("Delivered", out OrderStatus parsedStatus))
            {
                Console.WriteLine($"'Delivered' has been converted to the Enum value: {parsedStatus}");
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }
    }
}
