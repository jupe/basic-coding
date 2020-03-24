namespace extra_17
{
    public class Person
  {

    private string name;
    private int identityNumber;

    public Person(string name, int identityNumber)
    {
      this.name = name;
      this.identityNumber = identityNumber;
    }


    // BEGIN SOLUTION
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
      Person comparedPerson = (Person)compared;

      if (this.name == comparedPerson.name && 
          this.identityNumber == comparedPerson.identityNumber)
      {
        return true;
      }  
      // otherwise the objects are not equal
      return false;
    
    } 
  }
}