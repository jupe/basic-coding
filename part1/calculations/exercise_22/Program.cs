using System;

namespace exercise_22
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

      Console.WriteLine("Give the third number!");
      string value3 = Console.ReadLine();
      int intValue3 = Convert.ToInt32(value3);

      double avarage = (intValue + intValue2 + intValue3) / 3.0;
      Console.WriteLine("The average is " + avarage);
      // Write your code here:
    }
    
  }
}
