using System;
using System.Collections.Generic;

namespace extra_12
{
    public class Person
    {
        private string name;
        private int age;

        public Person (string name)
        {
            this.age = 0;
            this.name = name; 
        }
        public int GrowOlder(int howMuch)     
        {
            this.age = this.age + howMuch;
            return this.age;
        }
        public override string ToString()
        {
             return this.name + ", age " + this.age;
        }
    
    }
}