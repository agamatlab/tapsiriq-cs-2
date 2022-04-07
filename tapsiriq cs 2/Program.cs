using System;

class Program
{

    public static float add(float a, float b) => a + b;
    public static float sub(float a, float b) => a - b;
    public static float mult(float a, float b) => a * b;
    public static float div(float a, float b) => (b == 0) ? 0 : a / b;

    public static void Main(string[] args)
    {
        float num1, num2;
        char op;

        while (true)
        {
            Console.Write("Enter first number: ");
            float.TryParse(Console.ReadLine(), out num1);
            Console.Clear();

            do
            {
                Console.Write("Enter Operator(+,-,/,*): ");
                char.TryParse(Console.ReadLine(), out op);
                Console.Clear();
            } while (op != '-' && op != '+' && op != '/' && op != '*');

            Console.Write("Enter second number: ");
            float.TryParse(Console.ReadLine(), out num2);

            Console.Write($"{num1} {op} {num2} = ");
            switch (op)
            {
                case '+':
                    Console.WriteLine(add(num1, num2));
                    break;
                case '-':
                    Console.WriteLine(sub(num1, num2));
                    break;
                case '*':
                    Console.WriteLine(mult(num1, num2));
                    break;
                case '/':
                    Console.WriteLine(div(num1, num2));
                    break;
            }

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            string @continue;
            do
            {
                Console.WriteLine("Do you want to continue? YES/NO");
                @continue = Console.ReadLine();
                @continue = @continue?.ToLower();
                Console.Clear();
            } while (@continue != "no" && @continue != "yes");

            if (@continue == "no") break;
        }

    }
}