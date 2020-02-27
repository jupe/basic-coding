using System;

namespace exercise_113

{
  public class Book
  {

    public string title { get; set; }
    public int bages { get; set; }
    public string year { get; set; }

    public Book(string title, int bages, string Publication)
    {
      this.title = title;
      this.bages = bages;
      this.year = year;
    }

    public override string ToString()
    {
      return this.title + ", " + this.bages + " bages" + this.year;
    }
  }
}