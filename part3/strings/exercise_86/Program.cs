using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        string words = Console.ReadLine();
        if (words == "")
      {
        break;
      }  
        string[] parts = words.Split(" ");
        foreach (string line in parts)
        {
            Console.WriteLine(line);
        }
      }
    }
  }
}

