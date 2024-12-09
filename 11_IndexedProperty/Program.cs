using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        /* Your first task. After we went through everything let's put it to the test what you have learned. Below you can find a simple .CSV File which gets created and populated
            Your Task is now to determine a ColumnIndex and if it exists return the Value of the column. 
            And since Code produces errors... well handle them aswell ;)
         
         */

        // Step 1: Create CSV-File and populate it with values
        string csvFile = "example.csv";
        File.WriteAllText(csvFile, "Name,Age,City\nJohn,25,New York\nAlice,30,Los Angeles\nBob,22,Chicago");

        Console.WriteLine($"CSV-Datei '{csvFile}' wurde erstellt.\n");

        // Step 2: Read the CSV-File
        string[] lines = File.ReadAllLines(csvFile);

        // Step 3: Create Indexed Property (Columnname to Columnindex)
        string[] headers = lines[0].Split(',');

        // Step 4: Return Column
        Console.WriteLine("Welche Spalte möchtest du ausgeben? (Name, Age, City)");
        string columnName = Console.ReadLine();

        // TODO: Determine the ColumnIndex
        // Tip: Use Array.IndexOf(headers, columnName), to determine the Index.

        // TODO: If the ColumnIndex exists, return all Values of the Column.
        // Tip: Iterate from Row 1 (the Datarows) and use Split(',').

        // TODO: If the ColumnIndex does not exist, throw an error Message.
        // Tip: if-else seems like a good oppurturnity 
    }
}
