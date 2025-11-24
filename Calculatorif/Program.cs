using System;
using System.Runtime.CompilerServices;

namespace Calculatorif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введіть перше число");
            double virstValue = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Введіть друге число");
            double secondValue = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Введіть дію '+' '-' '*' '/' ");
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
                System.Console.WriteLine("Помилка");
            }
        }
    }
}