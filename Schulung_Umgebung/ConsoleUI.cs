using System;
using System.Linq;

namespace Schulung_Umgebung
{
    public class ConsoleUI
    {
        // Method to display CSV data in the console
        public void DisplayCsv(List<string[]> data)
        {
            // Iterate through each row in the data
            foreach (var row in data)
            {
                // Join the elements of the row with " | " and print them
                Console.WriteLine(string.Join(" | ", row));
            }
        }
    }
}
