namespace exercise_120
{
  public class Cube
  {
    private int edgeLength { get; set; }

    public Cube(int edgeLength)
    {
      this.edgeLength = edgeLength;
    }
    public int volume()
    {
      return this.edgeLength = this.edgeLength * this.edgeLength * this.edgeLength;
    }
  
    public override string ToString()
    {
      return "The lenght of the edge is " + this.edgeLength + " and the volume " + this.volume();
    }
 
  }
}