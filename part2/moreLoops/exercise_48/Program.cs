using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give numbers:");
      int summa = 0; 
      int validNumbers = 0;
      int even = 0;
      int odd = 0;

      while (true)

      {
        int intValue1 = Convert.ToInt32(Console.ReadLine());
        if (intValue1 == -1)
        {
          break;
        }
        summa += intValue1;
        validNumbers++;
        if ((intValue1 % 2) == 0)
        {
          even++;
        }
        else
        {
          odd++;
        }
      }
        Console.WriteLine("Thx! Bye!");
        Console.WriteLine("Sum: " + summa);
        Console.WriteLine("Numbers: " + validNumbers);
        Console.WriteLine("Average: " + (double)summa /validNumbers);
        Console.WriteLine("Even: " + even);
        Console.WriteLine("Odd: " + odd);
    }
  }
}
