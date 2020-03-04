using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      string number1 = Console.ReadLine();
      int intnumber1 = Convert.ToInt32(number1);

      Console.WriteLine("Give the second number!");
      string number2 = Console.ReadLine();
      int intNumber2 = Convert.ToInt32(number2);

      if (intnumber1 > intNumber2)
      {
        Console.WriteLine("The larger number is " + intnumber1 + "!");
      } 
      else if (intnumber1 < intNumber2)
      {
        Console.WriteLine("The larger number is " + intNumber2 + "!");
      }
      else if (intnumber1 == intNumber2)
      {
        Console.WriteLine("They are equal!");
      }    
    }
  }
}
