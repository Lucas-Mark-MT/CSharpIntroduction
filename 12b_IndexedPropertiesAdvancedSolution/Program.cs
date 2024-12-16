namespace _12b_IndexedPropertiesAdvancedSolution
{
    // CSVHandler.cs
    using System;
    using System.IO;

    class CSVHandler
    {
        private static string[] _headers; // Holds the column headers
        private static string[][] _data; // Holds the CSV data as a 2D array

        // SOLUTION: Dynamically handle varying delimiters in the CSV file (currently ',' is hardcoded).
        public static void LoadCSV(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath); // SOLUTION: Read all lines of the CSV file.

            _headers = lines[0].Split(','); // SOLUTION: Parse the header line using ','.

            _data = new string[lines.Length - 1][];
            for (int i = 1; i < lines.Length; i++)
            {
                _data[i - 1] = lines[i].Split(','); // SOLUTION: Parse remaining lines into the data array.
            }
        }

        // SOLUTION: Extend the indexer to handle cases with empty fields or inconsistent rows.
        public static string[] GetColumnValues(string columnName)
        {
            
            
                int columnIndex = Array.IndexOf(_headers, columnName); // SOLUTION: Find the column index by its name.

                if (columnIndex == -1)
                {
                    throw new ArgumentException($"Column '{columnName}' does not exist."); // SOLUTION: Handle non-existent columns.
                }

                string[] columnValues = new string[_data.Length];
                for (int i = 0; i < _data.Length; i++)
                {
                    if (columnIndex >= _data[i].Length) // SOLUTION: Handle inconsistent data rows.
                    {
                        columnValues[i] = "N/A"; // Default value for missing data.
                    }
                    else
                    {
                        columnValues[i] = _data[i][columnIndex];
                    }
                }
                return columnValues;
            
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            string csvFile = "example.csv"; // SOLUTION: File name hardcoded for now.

            // SOLUTION: Create and populate the CSV file with example content.
            File.WriteAllText(csvFile, "Name,Age,City\nLucas,25,Sankt Margrethen\nThomas,55,Vaduz\nAlois,60,Schaan");

            Console.WriteLine($"CSV file '{csvFile}' has been created.\n");

            try
            {
                CSVHandler.LoadCSV(csvFile); // SOLUTION: Load the CSV file into the handler.

                Console.WriteLine("Which column would you like to display? (Name, Age, City)");
                string columnName = Console.ReadLine(); // SOLUTION: Query the user for a column name.

                string[] columnValues = CSVHandler.GetColumnValues(columnName); // SOLUTION: Fetch column values using the indexer.

                Console.WriteLine($"\nValues in the column '{columnName}':");
                foreach (string value in columnValues) // SOLUTION: Print all values from the requested column.
                {
                    Console.WriteLine(value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); // SOLUTION: Basic error handling.
            }
        }
    }

}
