
using Schulung_Umgebung;

Console.WriteLine("Gib bitte den CSV Pfad ein: ");
string filePath = Console.ReadLine();

CSVImport csvImport = new CSVImport(filePath);
var consoleUI = new ConsoleUI();

try
{
    var data = csvImport.ReadCsv();

    consoleUI.DisplayCsv(data);
}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
