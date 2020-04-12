using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //1..Part Warehouse
      Warehouse WH = new Warehouse(100);
      Console.WriteLine(WH);
      WH.AddToWarehouse(10);
      Console.WriteLine(WH);
      WH.AddToWarehouse(100);
      Console.WriteLine(WH);
      WH.AddToWarehouse(-10);
      Console.WriteLine(WH);
      WH.TakeFromWarehouse(20);
      Console.WriteLine(WH);
      WH.TakeFromWarehouse(-20);
      Console.WriteLine(WH);

      Console.WriteLine();
      
      //2..Part ProductWarehouse
      ProductWarehouse juice = new ProductWarehouse("Juice", 1000);
      juice.AddToWarehouse(1000);
      juice.TakeFromWarehouse(11);
      Console.WriteLine(juice.productName); // Juice
      Console.WriteLine(juice);

      Console.WriteLine();

      //3..Part ChangeHistory
      ChangeHistory CH = new ChangeHistory();
      CH.Add(100);
      CH.Add(10);
      CH.Add(200);
      CH.Add(50);
      Console.WriteLine(CH);

      Console.WriteLine();

      //4..Part ProductWarehouseWithHistory
      ProductWarehouseWithHistory milk = new ProductWarehouseWithHistory("Milk", 1000, 100);
      Console.WriteLine(milk);
      milk.TakeFromWarehouse(10);
      Console.WriteLine(milk.History());
      Console.WriteLine(milk);
      milk.AddToWarehouse(100);
      Console.WriteLine(milk.History());
      Console.WriteLine(milk);
      milk.TakeFromWarehouse(-10000);
      Console.WriteLine(milk.History());
      Console.WriteLine(milk);

    }
  }
}
