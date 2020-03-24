using System;
using System.Collections.Generic;

namespace extra_17
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
       List<Person> persons = new List<Person>();

      while (true)
      {
        Console.WriteLine("Identifying number?");
        string number = Console.ReadLine();
        if (number == "")
        {
          break;
        }
        else 

        Console.WriteLine("Name (empty will stop):");
        string name = Console.ReadLine();
        if (name == "")
        {
          break;
        }

        
        Person person = new Person(number, name);

        // BEGIN SOLUTION
        // Add unique person to the list.
        // Remember to print
        // If the list Contains the person
        if (persons.Contains(person))
        {
            persons.Add(person);
        }
        // END SOLUTION
      }
      Console.WriteLine();
      // Don't alter the line below!
      Console.WriteLine("==Persons=="); 
      Console.WriteLine(persons);

    }
  }
}
