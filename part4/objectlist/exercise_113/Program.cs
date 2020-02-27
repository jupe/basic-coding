using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!
      List<Book> list = new List<Book>();
      while (true)
      {
          Console.Write("Name: ");
          String title = Console.ReadLine();
          if (title == "")
          {
             break;
          }
          Console.Write("Pages: ");
          int bages = Convert.ToInt32(Console.ReadLine());
          Console.Write("Publication year: ");
          string year = Console.ReadLine();
          list.Add(new Book(title, bages, year));
      }
      Console.WriteLine();

      Console.Write("What information will be printed? ");
      string printInformation = Console.ReadLine();

      foreach (Book item in list)
      {
          if (printInformation == "evetything")
          {
              Console.WriteLine(item);
          }
          else if (printInformation == "name")
          {
              Console.WriteLine(item.title);
          }
          else
          {
            break;
          }
      }
    }
  }
}




