using System;
using System.Collections.Generic;

namespace extra_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      List<Person> kindergarten = new List<Person>();
      Person mike = new Person("Mike");
      Person lilly = new Person("Lilly");
      lilly.GrowOlder(1);

      kindergarten.Add(mike);
      kindergarten.Add(lilly);

      foreach (Person child in kindergarten) 
      {
          Console.WriteLine(child);
      }
      
    }
  }
}
