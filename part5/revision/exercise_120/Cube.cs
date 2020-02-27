namespace exercise_120
{
  class Cube
  {
    public int edgeLength;
    public int Volume;
    public Cube(int edgeLength)
    {
      this.edgeLength = edgeLength;
      this.Volume = 0;
    }

    public int Volume()
    {
        return this.Volume = this.edgeLength * this.edgeLength * this.edgeLength;
    }
    public override string ToString()
    {
        return "The lenght of the edge is" + this.edgeLength + " and the volume " + this.Volume;
    }
  }
}