using System;

namespace ConvertorValut
{
  internal class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Введи курс євро до грн");
      double valueCurs = Convert.ToDouble(Console.ReadLine());
      System.Console.WriteLine("Вебери функцію");
      System.Console.WriteLine("1) Поміняти євро на гривні");
      System.Console.WriteLine("2) Поміняти гривні на євро");
      int functionValue = Convert.ToInt32(Console.ReadLine());
      if (functionValue == 1)
      {
        System.Console.WriteLine("Введи кількість євро");
        double euroCount = double.Parse(Console.ReadLine());
        double grnValue = valueCurs * euroCount;
        System.Console.WriteLine("Ти получиш: " + grnValue + " грн");
      }
      else if (functionValue == 2)
      {
        System.Console.WriteLine("Введи кількість грн");
        double grnCount = double.Parse(Console.ReadLine());
        double euroValue = grnCount / valueCurs;
        System.Console.WriteLine("Ти получиш " + euroValue + " євро");
      }
      else {
        System.Console.WriteLine("Виникла помилка, попробуй написати норм число");
      }
    }
  }
}
