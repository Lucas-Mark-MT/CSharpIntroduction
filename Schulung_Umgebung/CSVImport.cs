using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulung_Umgebung
{
    public class CSVImport
    {
        
        
          private readonly string _filePath;

        public CSVImport(string filePath) //Constructor with passing parameters, this way we can save passing parameters in the ReadCsv() method. Alternatively, the constructor can be deleted, and ReadCsv can hold the filePath. This approach is preferred for extensions, such as WriteCsv, following the DRY principle (Don't Repeat Yourself).
        {
            _filePath = filePath;
        }

        public List<string[]> ReadCsv() //Alternatively, the filePath can be passed as a parameter here. See line 15.
        {
            var rows = new List<string[]>();

            if (!File.Exists(_filePath))
                throw new FileNotFoundException("CSV file not found."); //If the file does not exist (!= 'Not'), an exception is thrown to prevent the program from crashing.

            try
            {
                foreach (string line in File.ReadLines(_filePath)) 
                {
                   
                    string[] fields = line.Split(','); //Here, the character can be changed to adjust the delimiter.
                    rows.Add(fields);
                }


                /* string[] lines = File.ReadLines(_filePath).ToArray();

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] fields = line.Split(','); // Here, the character can be changed to adjust the delimiter.
                    rows.Add(fields); 
                } */
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading the file: {ex.Message}");
            }

            return rows;
        }
    }
    
}
