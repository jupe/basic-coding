using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Dog dog = new Dog();
      dog.Bark();
      dog.Eat();

      Dog fido = new Dog("Fido");
      fido.Bark();

      Console.WriteLine();

      Cat cat = new Cat();
      cat.Purr();
      cat.Eat();

      Cat garfield = new Cat("Garfield");
      garfield.Purr();

      Console.WriteLine();

      INoiseCapable Dog = new Dog();
      Dog.MakeNoise();

      INoiseCapable Cat = new Cat("Garfield");
      Cat.MakeNoise();

      Cat c = (Cat) cat;
      c.Purr();
     
     
     
    }
  }
}
