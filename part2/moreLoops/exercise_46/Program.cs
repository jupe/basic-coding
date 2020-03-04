using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      
      int intValue = Convert.ToInt32(Console.ReadLine());
      int start = intValue;
      int end = 100;
      for (int i = start; i < end + 1; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
