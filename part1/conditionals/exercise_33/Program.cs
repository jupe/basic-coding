using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string word1 = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string word2 = Console.ReadLine();

      if (word1 == word2)
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
