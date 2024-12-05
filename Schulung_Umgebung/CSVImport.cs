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

        public CSVImport(string filePath) //Konstruktor mit Übergabeparameter dadurch können wir uns eine Parameterübergabe bei der ReadCsv() Methode sparen. Alternativ kann der Konstrukto gelöscht werden und die ReadCsv hält den filePath. Für erweiterungen wie zum Beispiel WriteCsv ist dieser Weg zu bevorzugen (DRY Prinzip)
        {
            _filePath = filePath;
        }

        public List<string[]> ReadCsv() //Alternativ kann hier der filePath als Parameter übergeben werden. Siehe Zeile 15
        {
            var rows = new List<string[]>();

            if (!File.Exists(_filePath))
                throw new FileNotFoundException("CSV file not found."); //Sollte die File nicht existieren ! = (Not) so wird eine Exception geworfen um den Crash des Programmes zu verhindern

            try
            {
                foreach (string line in File.ReadLines(_filePath)) 
                {
                   
                    string[] fields = line.Split(','); //Hier kann der char geändert werden um den Delimiter anzupassen
                    rows.Add(fields);
                }


                /* string[] lines = File.ReadLines(_filePath).ToArray();

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] fields = line.Split(','); // Hier kann der char geändert werden um den Delimiter anzupassen
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
