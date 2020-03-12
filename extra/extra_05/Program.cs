using System;
using System.Collections.Generic;

namespace extra_05
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      for (int i = 1; i < 6; i++)
      {
        Console.WriteLine(i);
      }
      Console.WriteLine("Give words, 'end' quits:");
      List<string> list = new List<string>();
      string input = "";
           
      while (true)
      {
        input = Console.ReadLine();
        if (input == "end")
        {
          break;
        }
        else
        {
          list.Add(input);
        }
        
      } 
      list.ForEach(Console.WriteLine);
    }

    
  }
}
