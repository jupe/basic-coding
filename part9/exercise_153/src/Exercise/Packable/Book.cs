namespace Exercise
{
  public class Book : IPackable
  {

    public string author;
    public string bookName;
    public int bYear;
    public int weight;
    public Book(string author, string bookName, int bYear)
    {
      this.author = author;
      this.bookName = bookName;
      this.bYear = bYear;
      this.weight = 1;
    }

    
    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.author + ": " + this.bookName + " (" + this.bYear + ")";
    }
  }
}
