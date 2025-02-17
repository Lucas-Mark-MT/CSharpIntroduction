using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create CSV file and populate it with values
        string csvFile = "example.csv";
        File.WriteAllText(csvFile, "Name,Age,City\nLucas,25,Sankt Margrethen\nThomas,55,Vaduz\nAlois,60,Schaan");

        Console.WriteLine($"CSV file '{csvFile}' has been created.\n");

        // Step 2: Read the CSV file
        string[] lines = File.ReadAllLines(csvFile);

        // Step 3: Create Indexed Property (Column name to Column index)
        string[] headers = lines[0].Split(',');

        // Step 4: Ask user for the column they want to display
        Console.WriteLine("Which column would you like to display? (Name, Age, City)");
        string columnName = Console.ReadLine();

        // Step 5: Determine the ColumnIndex
        int columnIndex = Array.IndexOf(headers, columnName);

        if (columnIndex == -1)
        {
            Console.WriteLine("Column not found.");
        }
        else
        {
            Console.WriteLine($"\nValues of the column '{columnName}':");
            for (int i = 1; i < lines.Length; i++) // Rows from 1 since Row 0 contains the Header
            {
                string[] values = lines[i].Split(',');
                Console.WriteLine(values[columnIndex]);
            }
        }
    }
}
