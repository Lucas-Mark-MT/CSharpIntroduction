using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        /* Your first task. After we went through everything let's put it to the test what you have learned. Below you can find a simple .CSV File which gets created and populated
            Your Task is now to determine a ColumnIndex and if it exists return the Value of the column. 
            And since Code produces errors... well handle them as well ;).
         */

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

        // TODO: Determine the ColumnIndex
        // Tip: Use Array.IndexOf(headers, columnName), to determine the Index.

        // TODO: If the ColumnIndex exists, return all values of the Column.
        // Tip: Iterate from Row 1 (the Data rows) and use Split(',').

        // TODO: If the ColumnIndex does not exist, throw an error message.
        // Tip: if-else seems like a good opportunity 
    }
}
