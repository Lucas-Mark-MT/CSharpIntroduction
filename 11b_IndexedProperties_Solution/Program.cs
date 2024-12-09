using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
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

        // Step 5: Determine the ColumnIndex
        int columnIndex = Array.IndexOf(headers, columnName);

        if (columnIndex == -1)
        {
            Console.WriteLine("Spalte nicht gefunden.");
        }
        else
        {
            Console.WriteLine($"\nWerte der Spalte '{columnName}':");
            for (int i = 1; i < lines.Length; i++) // Rows from 1 since Row 0 contains the Header
            {
                string[] values = lines[i].Split(',');
                Console.WriteLine(values[columnIndex]);
            }
        }
    }
}
