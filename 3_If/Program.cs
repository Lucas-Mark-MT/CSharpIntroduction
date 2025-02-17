namespace _3_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Simple if-condition
            int number = 10;
            if (number > 5)
            {
                Console.WriteLine("1. The number is greater than 5.");
            }

            // 2. If-else condition
            if (number % 2 == 0) // The percent sign, also known as modulo, divides all numbers by 2 in this case. If the remainder is 0, the number is logically even.
            {
                Console.WriteLine("2. The number is even.");
            }
            else
            {
                Console.WriteLine("2. The number is odd.");
            }

            // 3. Else-if condition
            string name = "Lucas";
            if (name == "Tom") // 1 "=" is an assignment operator, 2 "==" is a comparison operator
            {
                Console.WriteLine("3. Hello Tom!");
            }
            else if (name == "Lucas")
            {
                Console.WriteLine("3. Hello Lucas!");
            }
            else
            {
                Console.WriteLine("3. I don't know your name.");
            }

            // 4. Nested if-condition
            int age = 24;
            bool hasPermission = true;

            if (age >= 18)
            {
                if (hasPermission)
                {
                    Console.WriteLine("4. You are an adult and have permission.");
                }
                else
                {
                    Console.WriteLine("4. You are an adult but do not have permission.");
                }
            }
            else
            {
                Console.WriteLine("4. You are a minor.");
            }

            // 5. Inline if-condition (ternary operator)
            bool isLoggedIn = false;
            Console.WriteLine(isLoggedIn ? "5. Welcome back!" : "5. Please log in.");

            // 6. Multiple conditions with logical operators
            int temperature = 25;
            if (temperature > 15 && temperature < 30)
            {
                Console.WriteLine("6. The weather is pleasant.");
            }
            else if (temperature <= 15)
            {
                Console.WriteLine("6. It is quite cold.");
            }
            else
            {
                Console.WriteLine("6. It is quite hot.");
            }

            // 7. Negation in a condition
            bool hasAccess = false;
            if (!hasAccess)
            {
                Console.WriteLine("7. Access denied.");
            }
        }
    }
}
