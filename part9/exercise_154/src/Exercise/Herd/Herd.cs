namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Herd : IMovable
  {
    private List<IMovable> list;
    public Herd()
    {
      this.list = new List <IMovable>();
    }

    public void AddToHerd(IMovable movable)
    {
      this.list.Add(movable);
    }

    public void Move(int dx, int dy)
    {
      foreach (IMovable item in list)
      {
        item.Move(dx, dy);
      }
    }

    public override string ToString()
    {
      return "x: " + this.x + "; y: " + this.y;
    }
  }
}