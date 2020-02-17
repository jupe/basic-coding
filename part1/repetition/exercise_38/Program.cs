using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
    
    
      // Write your code here:
      int countNeg = 0;
      while (true)
      {
      Console.WriteLine("Give a number:");
      int intNumber = Convert.ToInt32(Console.ReadLine());
      if (intNumber == 0)
      {
        break;
      }

      if (intNumber < 0)
      {
        countNeg ++;
      }
    }
    Console.WriteLine("Total amount of negative numbers: " + countNeg);
    }
  }
}
