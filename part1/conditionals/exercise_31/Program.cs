using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string number1 = Console.ReadLine();
      int intnumber1 = Convert.ToInt32(number1);

      if ((intnumber1 % 2) == 0)
      {
        Console.WriteLine("It is even.");
      }
      else
      {
        Console.WriteLine("It is odd.");
      }



    }
  }
}
