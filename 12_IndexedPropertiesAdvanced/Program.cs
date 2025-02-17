namespace _12_IndexedPropertiesAdvanced
{
    // CSVHandler.cs
    using System;

    class CSVHandler
    {

        // TODO: Dynamically handle varying delimiters in the CSV file (e.g., semicolons, tabs).
        public static void LoadCSV(string filePath)
        {
            // TODO: Read all lines of the CSV file.
            // TODO: Parse the header line using a configurable delimiter.
            // TODO: Parse remaining lines into a 2D array for data storage.
        }

        // TODO: Extend the indexer to handle cases with empty fields or inconsistent rows.
        public string[] this[string columnName]
        {
            get
            {
                // TODO: Find the column index by its name.
                // TODO: Handle cases where the column name does not exist.
                // TODO: Handle missing or inconsistent fields in the data rows.
                return null; // Placeholder
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Allow the user to specify the file name dynamically instead of hardcoding it.
            string csvFile = "example.csv";

            // TODO: Allow the user to specify delimiter type (e.g., ',' or ';').
            // TODO: Create and populate the CSV file with example content.

            try
            {
                // TODO: Load the CSV file into the handler.
                CSVHandler.LoadCSV(csvFile);

                // TODO: Query the user for a column name.
                // TODO: Validate the user input to ensure a valid column name is provided.
                // TODO: Fetch and display the values of the requested column using the indexer.
            }
            catch (Exception ex)
            {
                // TODO: Add specific error handling for common issues (e.g., file not found, invalid format).
            }
        }
    }

}
