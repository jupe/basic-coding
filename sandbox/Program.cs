using System;

namespace sandbox
{

  class Program
  {
    public static void Main(String[] args)
    {
    ChristmasTree (10);
    Console.WriteLine(" ");
    //PrintRightTriangle(4);
    //ChristmasTree (4);

    }

    public static void PrintStars(int number)
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    
    }

    public static void PrintSpaces(int number)
    {
      for (int i = 0; i < number; i++)
      {
      Console.Write(" ");
      }
    }

    public static void PrintRightTriangle(int size)
    {
      int left = size -1;
      for (int i = 1; i <= size; i++)
             
      {
        PrintSpaces(left);
        PrintStars(i);
        left--;
      }
        
    }


    public static void ChristmasTree(int height)
    {
      
      for (int i =1; i <= height; i++)
      {
        PrintSpaces(height - i);
        PrintStars((2 * i) -1);
       
      }
      PrintSpaces(height - 2);
      PrintStars(3);
      PrintSpaces(height - 2);
      PrintStars(3);
    }
  }
}
       

