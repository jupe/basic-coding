using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string message2 = Console.ReadLine();
      Console.WriteLine("Give a double:");
      string message3 = Console.ReadLine();
      double number = Convert.ToDouble(message3);
      Console.WriteLine("Give a boolean:");
      string message4 = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(message4);
      Console.WriteLine("Your string: " + message);
      Console.WriteLine("Your integer: " + message2);
      Console.WriteLine("Your double: " + message3);
      Console.WriteLine("Your boolean: " + booleanValue);
      // Write your code here:

    }
  }
}
