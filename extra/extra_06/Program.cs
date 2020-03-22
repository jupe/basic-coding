using System;

namespace extra_06
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      int num = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(Console.ReadLine());
      double squareRoot = Math.Sqrt(num + num2);
      
      if (squareRoot > 0)
      {
        Console.WriteLine(squareRoot);
      }
      else 
      {
        Console.WriteLine("0");
      }
    }
  }
}
