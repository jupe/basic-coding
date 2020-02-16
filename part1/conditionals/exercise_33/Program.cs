using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string string1 = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string string2 = Console.ReadLine();

      if (string1 == string2)
      { 
        Console.WriteLine("Echo!");
      }
      else 
      {
        Console.WriteLine("Nope!");
      }
    }
  }
}
