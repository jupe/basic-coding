using System;

namespace Exercise
{
  public class SimpleDate
  {
    private int day;
    private int month;
    private int year;

    public SimpleDate(int day, int month, int year)
    {
      this.day = day;
      this.month = month;
      this.year = year;
    }

    public override string ToString()
    {
      return this.day + "." + this.month + "." + this.year;
    }

    public bool Earlier(SimpleDate compared)
    {
      if (this.year < compared.year)
      {
        return true;
      }
      if (this.year == compared.year && this.month < compared.month)
      {
        return true;
      }
      if (this.year == compared.year && this.month == compared.month &&
          this.day < compared.day)
      {
        return true;
      }
      return false;
    }

    public override bool Equals(object compared)
    {
      // DO SOMETHING HERE
      if (this == compared)
      {
          return true;
      }
      if ((compared == null) || !this.GetType().Equals(compared.GetType())) 
    
      { 
          return false;
      }
      // Converts the object to an object specific to this class.      
      SimpleDate comparedSimpleData = (SimpleDate)compared;
      
      // If the values of the object variables are the same, the objects are equal
      return this.day == comparedSimpleData.day &&
          this.month == comparedSimpleData.month &&
          this.year == comparedSimpleData.year;
    }

    public override int GetHashCode()
    {
      // DO SOMETHING HERE
      return HashCode.Combine(this.day, this.month, this.year);
    }
  }
}