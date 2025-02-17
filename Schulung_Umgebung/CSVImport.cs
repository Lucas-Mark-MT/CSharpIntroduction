using System;
using System.Linq;

namespace Schulung_Umgebung
{
    public class CSVImport
    {
        private readonly string _filePath;

        // Constructor with a parameter to accept the file path and store it
        public CSVImport(string filePath)
        {
            _filePath = filePath;
        }

        // Method to read data from a CSV file and return it as a list of string arrays
        public List<string[]> ReadCsv()
        {
            var rows = new List<string[]>();

            // Check if the file exists, throw an exception if not
            if (!File.Exists(_filePath))
                throw new FileNotFoundException("CSV file not found.");

            try
            {
                // Read each line from the file and split it by commas to separate the fields
                foreach (string line in File.ReadLines(_filePath))
                {
                    string[] fields = line.Split(','); // Adjust the delimiter if needed
                    rows.Add(fields);
                }
            }
            catch (Exception ex)
            {
                // Throw an exception with the error message if something goes wrong during the file read
                throw new Exception($"Error reading the file: {ex.Message}");
            }

            return rows; // Return the rows read from the CSV file
        }
    }
}
