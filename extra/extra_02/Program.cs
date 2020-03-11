using System;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give three numbers:");
      int number1 = Convert.ToInt32(Console.ReadLine());
      int number2 = Convert.ToInt32(Console.ReadLine());
      int number3 = Convert.ToInt32(Console.ReadLine());
      if (number1 > number2 & number1 > number3)
      {
        Console.WriteLine("Largest: " + number1);
      }
      else if (number1 < number2 & number2 > number3)
      {
        Console.WriteLine("Largest: " + number2);
      }
      else 
      {
        Console.WriteLine("Largest: " + number3);
      }
    }
  }
}
