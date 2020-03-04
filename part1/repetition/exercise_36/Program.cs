using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true)
    {
      Console.WriteLine("Give a number:");
      string value1 = Console.ReadLine();
      int intValue1 = Convert.ToInt32(value1);
      if (intValue1 == 0)
      {
        break;
      }
      
      else if (intValue1 < 0)
     
      {
        Console.WriteLine("That is negative");
      } 
      else
      {
        Console.WriteLine(intValue1 * intValue1);
      }
    }
    }
  }
}
