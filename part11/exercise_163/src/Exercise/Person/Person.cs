namespace Exercise
{
  using System;
  public class Person
  {

    public string name { get; }
    public int age { get; }

    public Person(string name, int age)
    {
      if (name == "" || name == null || name.Length > 40)
      {
      throw new ArgumentException("Name should not be null, or empty or longer than 40");
      }
       if (age < 0 || age > 120)
      {
      throw new ArgumentException("The age must be between 0 and 120");
      }
      this.name = name;
      this.age = age;
      
    }
  }
}
