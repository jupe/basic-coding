using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string value1 = Console.ReadLine();
      int intValue = Convert.ToInt32(value1);
      Console.WriteLine("Give the second number!");
      string value2 = Console.ReadLine();
      int intValue2 = Convert.ToInt32(value2);
      double avarage = (intValue + intValue2) / 2.0;
      Console.WriteLine("The average is " + avarage);
      // Write your code here:

    }
  }
}
