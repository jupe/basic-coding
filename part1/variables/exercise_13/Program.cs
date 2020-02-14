using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number!");
      string message = Console.ReadLine();
      double number = Convert.ToDouble(message);
      Console.WriteLine("You gave " + number);
      
    }
  }
}
