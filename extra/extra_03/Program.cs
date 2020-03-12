using System;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("How many numbers?");
      int sum = 0;
      int count = 0;
      while (true)
      {
        
        int numbers = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give " + numbers + " numbers:");
        if (numbers == 0)
        {
          int numbers2 = Convert.ToInt32(Console.ReadLine());
        }
        
        else 
        {
          sum = sum + numbers;
          count++;
        }  
      }
      
      Console.WriteLine("Their sum: " + sum);
      Console.WriteLine("Their total: " + count);
      Console.WriteLine("Their average: " + (double) sum / count);
    }
  }
}
