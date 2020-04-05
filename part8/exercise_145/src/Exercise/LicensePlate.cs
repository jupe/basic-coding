using System;
namespace Exercise
{
  public class LicensePlate
  {
    public string liNumber { get; }
    private string country;

    public LicensePlate(string country, string liNumber)
    {
      this.liNumber = liNumber;
      this.country = country;
    }


    public override string ToString()
    {
      return country + " " + liNumber;
    }

    public override bool Equals(object compared)
    {
      if (this == compared)
      {
        return true;
      }
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }
      LicensePlate comparedPlate = (LicensePlate)compared;
      // If the values of the object variables are the same, 
      //the objects are equal.
      return this.liNumber == comparedPlate.liNumber &&
          this.country == comparedPlate.country;
    }


    public override int GetHashCode()
    {
      return HashCode.Combine(this.liNumber, this.country);
    }
  }
}