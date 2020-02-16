using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:");
      string age = Console.ReadLine();
      int speed = Convert.ToInt32(age);
      if (speed < 1900)
     {
        Console.WriteLine("You're old");
      } 
    }
  }
}
