using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulung_Umgebung
{
    public class ConsoleUI
    {
        public void DisplayCsv(List<string[]> data)
        {
            foreach(var row in data)
            {
                Console.WriteLine(string.Join(" | ", row));
            }
        }
    }
}
