using System;

namespace exercise_126
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Try your code here, if you want
      {
      PaymentCard petesCard = new PaymentCard(10);

      Console.WriteLine("money " + petesCard.balance);
      bool wasSuccessful = petesCard.takeMoney(8);
      Console.WriteLine("successfully withdrew: " + wasSuccessful);
      Console.WriteLine("money " + petesCard.balance);

      wasSuccessful = petesCard.takeMoney(4);
      Console.WriteLine("successfully withdrew: " + wasSuccessful);
      Console.WriteLine("money " + petesCard.balance);

      }
    }
  }
}
