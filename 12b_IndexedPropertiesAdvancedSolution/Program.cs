using System;

namespace _12b_IndexedPropertiesAdvancedSolution
{
    class CSVHandler
    {
        private string[] _headers; // Holds the column headers
        private string[][] _data; // Holds the CSV data as a 2D array

        // Load CSV file
        public void LoadCSV(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            _headers = lines[0].Split(',');

            _data = new string[lines.Length - 1][];
            for (int i = 1; i < lines.Length; i++)
            {
                _data[i - 1] = lines[i].Split(',');
            }
        }

        // Indexer to access a row by index
        public string[] this[int rowIndex]
        {
            get
            {
                if (rowIndex < 0 || rowIndex >= _data.Length)
                {
                    throw new IndexOutOfRangeException("Row index is out of bounds.");
                }
                return _data[rowIndex];
            }
        }

        // Indexer to access a specific column in a row using column name
        public string this[int rowIndex, string columnName]
        {
            get
            {
                if (rowIndex < 0 || rowIndex >= _data.Length)
                {
                    throw new IndexOutOfRangeException("Row index is out of bounds.");
                }

                int columnIndex = Array.IndexOf(_headers, columnName);
                if (columnIndex == -1)
                {
                    throw new ArgumentException($"Column '{columnName}' does not exist.");
                }

                if (columnIndex >= _data[rowIndex].Length)
                {
                    return "N/A"; // Default value for missing data
                }
                return _data[rowIndex][columnIndex];
            }
        }

        // Method to get column values
        public string[] GetColumnValues(string columnName)
        {
            int columnIndex = Array.IndexOf(_headers, columnName);

            if (columnIndex == -1)
            {
                throw new ArgumentException($"Column '{columnName}' does not exist.");
            }

            string[] columnValues = new string[_data.Length];
            for (int i = 0; i < _data.Length; i++)
            {
                if (columnIndex >= _data[i].Length)
                {
                    columnValues[i] = "N/A";
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
            string csvFile = "example.csv";
            File.WriteAllText(csvFile, "Name,Age,City\nLucas,25,Sankt Margrethen\nThomas,55,Vaduz\nAlois,60,Schaan");

            Console.WriteLine($"CSV file '{csvFile}' has been created.\n");

            try
            {
                // Create an instance of CSVHandler
                CSVHandler handler = new CSVHandler();

                handler.LoadCSV(csvFile);

                Console.WriteLine("Which column would you like to display? (Name, Age, City)");
                string columnName = Console.ReadLine();

                string[] columnValues = handler.GetColumnValues(columnName);
                Console.WriteLine($"\nValues in the column '{columnName}':");
                foreach (string value in columnValues)
                {
                    Console.WriteLine(value);
                }

                // Access a specific row using the indexer
                Console.WriteLine("\nAccessing a specific row using indexer [1]:");
                string[] row1 = handler[1];
                Console.WriteLine(string.Join(", ", row1));

                // Access a specific value using row index and column name
                Console.WriteLine("\nAccessing a specific value using indexer [1, \"City\"]:");
                Console.WriteLine(handler[1, "City"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
