﻿using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = 0;
      string name = "";
      while (true)
      {
        string asked = Console.ReadLine();
        if (asked == "")
        {
          break;
        }
        string[] pieces = asked.Split(",");
        if (Convert.ToInt32(pieces[1]) > oldest)
        {
          oldest = Convert.ToInt32(pieces[1]);
          name = pieces[0];
        }
        
      }
        Console.WriteLine("Name of the oldest: " + name);
           
    
    
      }
     
  } 
}


