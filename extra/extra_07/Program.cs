using System;

namespace extra_07
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give integers, 'end' quits:");
      int sum = 0;
      
      while (true)

      {
        string row = Console.ReadLine();

        if (row == "end")
        {
          break;
        }
        int number = Convert.ToInt32(row);
        sum ++;
      }   
      
      
      Console.WriteLine("Sum: " + sum);
    }
  }
}
