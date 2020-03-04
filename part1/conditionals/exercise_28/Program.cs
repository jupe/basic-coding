using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("How old are you?");
      string age = Console.ReadLine();
      int age1 = Convert.ToInt32(age);
      if (age1 < 18)
      {
        Console.WriteLine("You're under age!");
      } 
      else
      {
        Console.WriteLine("You're an adult!");
      }
    }
  }
}
