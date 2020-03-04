using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = 2020;
      int length = 0;
      string name = "";
      int age = 0;
      int nameLenght = 0;

      while (true)
      {
        string asked =Console.ReadLine();
        if (asked == "")
        {
          break;
        }
        string[] pieces = asked.Split(",");
        if (oldest > (Convert.ToInt32(pieces[1])))
        {
          oldest = Convert.ToInt32(pieces[1]);
        }
        string word = pieces[0];
        length = word.Length;
        if (length > nameLenght)
        {
          nameLenght =  length;
          name = pieces[0];
        }
      }
    age = 2020 - oldest;

    Console.WriteLine("Longest name: " + name);
    Console.WriteLine("Highest age: " + age);
    }
  }
}



