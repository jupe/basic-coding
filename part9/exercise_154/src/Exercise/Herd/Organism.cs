using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Organism : IMovable
  {
    public int x;
    public int y;
    public int dx;
    public int dy;
    public Organism(int x, int y)
    {
      this.x = 0;
      this.y = 0;
    }
    public void Move(int dx, int dy)
    {
      this.dx = 0;
      this.dy = 0;
    }

    public override string ToString()
    {
      return "";
    }
  }
}