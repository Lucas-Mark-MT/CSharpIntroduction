namespace _7_Enum
{
    internal class Program
    {
        // 1. Enum-Deklaration
        enum DayOfWeek
        {
            Monday,    // Standardmäßig startet der Wert bei 0
            Tuesday,   // 1
            Wednesday, // 2
            Thursday,  // 3
            Friday,    // 4
            Saturday,  // 5
            Sunday     // 6
        }

        enum OrderStatus
        {
            Pending = 1,   // Manuelle Zuweisung eines Werts
            Shipped = 2,
            Delivered = 3,
            Cancelled = 4
        }



        static void Main(string[] args)
        {
            // 2. Verwendung von Enums
            Console.WriteLine("1. Enum-Wert ausgeben:");
            DayOfWeek today = DayOfWeek.Friday;
            Console.WriteLine($"Heute ist: {today}");

            // 3. Enum-Wert in Ganzzahl konvertieren
            Console.WriteLine("\n2. Enum-Wert als Ganzzahl:");
            int numericValue = (int)today;
            Console.WriteLine($"Der numerische Wert von {today} ist: {numericValue}");

            // 4. Enum-Wert aus Ganzzahl zurückkonvertieren
            Console.WriteLine("\n3. Ganzzahl in Enum-Wert umwandeln:");
            DayOfWeek convertedDay = (DayOfWeek)4;
            Console.WriteLine($"Die Ganzzahl 4 entspricht: {convertedDay}");

            // 5. Iteration über Enum-Werte
            Console.WriteLine("\n4. Iteration über alle Enum-Werte:");
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine($"Tag: {day} (Numerischer Wert: {(int)day})");
            }

            // 6. Enum mit benutzerdefinierten Werten
            Console.WriteLine("\n5. Enum mit benutzerdefinierten Werten:");
            OrderStatus status = OrderStatus.Shipped;
            Console.WriteLine($"Der Bestellstatus ist: {status} (Numerischer Wert: {(int)status})");

            // 7. Enum-Wert als Zeichenkette konvertieren
            Console.WriteLine("\n6. Enum-Wert in Zeichenkette konvertieren:");
            string statusString = status.ToString();
            Console.WriteLine($"Der Status als Zeichenkette: {statusString}");

            // 8. Zeichenkette in Enum-Wert umwandeln
            Console.WriteLine("\n7. Zeichenkette in Enum-Wert umwandeln:");
            if (Enum.TryParse("Delivered", out OrderStatus parsedStatus))
            {
                Console.WriteLine($"'Delivered' wurde in den Enum-Wert konvertiert: {parsedStatus}");
            }
            else
            {
                Console.WriteLine("Konvertierung fehlgeschlagen.");
            }
        }
    }
}
