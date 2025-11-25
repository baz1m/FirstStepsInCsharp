using System;
using System.Runtime.CompilerServices;

namespace Calculatorif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введіть перше число");
            if (!double.TryParse(Console.ReadLine(), out double virstValue))
            {
            Console.WriteLine("Помилка, введіть число!");
            return;
            }
            System.Console.WriteLine("Введіть друге число");
            if (!double.TryParse(Console.ReadLine(), out double secondValue))
            {
            Console.WriteLine("Помилка, введіть число!");
            return;
            }
            System.Console.WriteLine("Введіть дію '+' '-' '*' '/' ");
            string error = "Помилка, уведіть число";
            string action = Console.ReadLine();
            if (action == "+") {
                System.Console.WriteLine("Відповідь: " + (virstValue + secondValue));
            }
            else if (action == "-") {
                System.Console.WriteLine("Відповідь: " + (virstValue - secondValue));
            }
            else if (action == "*") {
                System.Console.WriteLine("Відповідь: " + (virstValue * secondValue));
            }
            else if (action == "/") {
                System.Console.WriteLine("Відповідь: " + (virstValue / secondValue));
            }
            else {
                System.Console.WriteLine(error);
            }
        }
    }
}