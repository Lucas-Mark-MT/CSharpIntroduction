using Schulung_Umgebung;


// Prompt the user to enter the CSV file path
Console.WriteLine("Please enter the CSV file path: ");
string filePath = Console.ReadLine();

// Create an instance of CSVImport with the provided file path
CSVImport csvImport = new CSVImport(filePath);

// Create an instance of ConsoleUI for displaying the data
var consoleUI = new ConsoleUI();

try
{
    // Attempt to read the CSV data from the file
    var data = csvImport.ReadCsv();

    // Display the data using the ConsoleUI class
    consoleUI.DisplayCsv(data);
}
catch (Exception ex)
{
    // If there’s an error (e.g., file not found, reading issue), display the error message
    Console.WriteLine($"Error: {ex.Message}");
}
