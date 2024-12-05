namespace _3_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. simple if-condition
            int number = 10;
            if (number > 5)
            {
                Console.WriteLine("1. Die Zahl ist größer als 5.");
            }

            // 2. if-else-condition
            if (number % 2 == 0) //The percent sign, also known as modulo, divides all numbers by 2 in this case. If the remainder is 0, the number is logically even.
            {
                Console.WriteLine("2. Die Zahl ist gerade.");
            }
            else
            {
                Console.WriteLine("2. Die Zahl ist ungerade.");
            }

            // 3. else-if-condition
            string name = "Lucas";
            if (name == "Tom") // 1 "=" is an Assinging- , 2 "==" is a Comparisonoperator

            {
                Console.WriteLine("3. Hallo Tom!");
            }
            else if (name == "Lucas")
            {
                Console.WriteLine("3. Hallo Lucas!");
            }
            else
            {
                Console.WriteLine("3. Ich kenne deinen Namen nicht.");
            }

            // 4. jagged if-condition
            int age = 24;
            bool hasPermission = true;

            if (age >= 18)
            {
                if (hasPermission)
                {
                    Console.WriteLine("4. Du bist volljährig und hast eine Erlaubnis.");
                }
                else
                {
                    Console.WriteLine("4. Du bist volljährig, aber hast keine Erlaubnis.");
                }
            }
            else
            {
                Console.WriteLine("4. Du bist minderjährig.");
            }

            // 5. inlined if-condition (ternary operator)
            bool isLoggedIn = false;
            Console.WriteLine(isLoggedIn ? "5. Willkommen zurück!" : "5. Bitte melde dich an.");

            // 6. multiple conditions with logical operators
            int temperature = 25;
            if (temperature > 15 && temperature < 30)
            {
                Console.WriteLine("6. Das Wetter ist angenehm.");
            }
            else if (temperature <= 15)
            {
                Console.WriteLine("6. Es ist ziemlich kalt.");
            }
            else
            {
                Console.WriteLine("6. Es ist ziemlich heiß.");
            }

            // 7. Negation in a condition
            bool hasAccess = false;
            if (!hasAccess)
            {
                Console.WriteLine("7. Zugriff verweigert.");
            }
        }
    }
}

