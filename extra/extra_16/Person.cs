using System;
using System.Collections.Generic;

namespace extra_16
{
    public class Person
    {
        public string name;
        public int age;
        public int height;
        public int weight;

        public Person (string name)
        {
            this.name = name; 
    
        }

         public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public Person(string name, int age, int height, int weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight; 
        }
        

        public override string ToString()
        {
             return this.name + ", age " + this.age + ", height " + this.height + "cm, weight " + this.weight + "kg";
        }
       
        
    }    
}