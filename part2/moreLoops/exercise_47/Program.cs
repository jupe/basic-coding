using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int intValue1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int intValue2 = Convert.ToInt32(Console.ReadLine());
      int start = intValue2;
      int end = intValue1;
      for (int i = start; i < end + 1; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
