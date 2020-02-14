using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How many days?");
      string message = Console.ReadLine();
      int intValue = Convert.ToInt32(message);
      int sum = ((60 * 60) * 24);
      Console.WriteLine((sum) * (intValue));
      // Write your code here:

    }
  }
}
