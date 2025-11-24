using System;

namespace Calculatorswitch
{

    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введіть перше число");
            double a = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Введіть друге число");
            double b = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Виберіть дію");
            System.Console.WriteLine("1 - Додавання");
            System.Console.WriteLine("2 - Віднімання");
            System.Console.WriteLine("3 - Множення");
            System.Console.WriteLine("4 - Ділення");  
            int diya = Convert.ToInt32(Console.ReadLine());
            switch (diya) {
                case 1:
                System.Console.WriteLine("Відповідь: " + a+b);
                break;
                case 2:
                System.Console.WriteLine("Відповідь: " + (a-b));
                break;
                case 3:
                System.Console.WriteLine("Відповідь: " + a*b);
                break;
                case 4:
                System.Console.WriteLine("Відповідь: " + a/b);
                break;
                default: 
                System.Console.WriteLine("Помилка, не правильне значення");
                break;
            }
        }
    }
}