using System;

namespace extra_04
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string number1 = Console.ReadLine();
      int intnumber1 = Convert.ToInt32(number1);

      
      if (intnumber1 < 0 )
      {
        Console.WriteLine("Impossible");
      } 
      else if (intnumber1 >0 && intnumber1 <50)
      {
        Console.WriteLine("Fail");
      }
      else if (intnumber1 >49 && intnumber1 <60)
      {
        Console.WriteLine("Grade: 1");
      }   
      else if (intnumber1 >59 && intnumber1 <70)
      {
        Console.WriteLine("Grade: 2");
      }   
      else if (intnumber1 >69 && intnumber1 <80)
      {
        Console.WriteLine("Grade: 3");
      }   
      else if (intnumber1 > 79 && intnumber1 <90)
      {
        Console.WriteLine("Grade: 4");
      }   
      else if (intnumber1 > 89 && intnumber1 <101)
      {
        Console.WriteLine("Grade: 5");
      }   
      else if (intnumber1 > 100)
      {
        Console.WriteLine("Outstanding!");
        
      }   
    }
  }
}
