using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int count = 0;
      while (true)

      {
      Console.WriteLine("Give a number:");
      int intNumber = Convert.ToInt32(Console.ReadLine());
      if (intNumber == 0)
      {
        break;
      }

      else
      {
        sum = sum + intNumber; 
        count++;
      }
      
    }
    Console.WriteLine("Total sum of numbers: " + sum);
    Console.WriteLine("Total amount of numbers: " + count);
    }
  }
}
