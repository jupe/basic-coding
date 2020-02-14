using System;

namespace exercise_17
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
      Console.WriteLine("The sum is " + (intValue + intValue2));

      // Write your code here:

    }
  }
}
