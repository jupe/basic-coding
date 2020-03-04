using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int start = 0;
      
      
      int intValue = Convert.ToInt32(Console.ReadLine());
      int end = intValue;
      for (int i = start; i < end + 1; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
