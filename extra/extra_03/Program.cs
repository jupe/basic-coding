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
      int count = 1;
     
      
      {
        
        int numbers = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give " + numbers + " numbers:");
        for (int i = 0; i < numbers; i++)
        {
          int numbers2 = Convert.ToInt32(Console.ReadLine());
          sum = numbers2 + sum;
          count = numbers2 * count; 
        }  
          
        
        Console.WriteLine("Their sum: " + sum);
        Console.WriteLine("Their total: " + count);
        Console.WriteLine("Their average: " + (double) sum / count);
      
      }
    }  
  }
}
