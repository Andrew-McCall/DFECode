using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFECSharp
{
    class Person
    {
        public string LocalName { get; private set; }
        public string Gender { get; private set; }
        public int Age { get; set; }

        public Person(string name, int age, string gender)
        {
            Console.WriteLine("New Person Created");
            this.LocalName = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person(string name, int age)
        {
            Console.WriteLine("New Person Created");
            this.LocalName = name;
            this.Age = age;
            this.Gender = "Not Given";
        }

        private void Funny()
        {
            Console.WriteLine("A fish swam into a concrete wall, He said Dam!");
        }

        public void Hello(Person other) // Ext if/case you know this person (hardcoded) Say something special
        {
            Console.WriteLine($"Hello, {other.LocalName}. My name is {this.LocalName}");
            Funny();
        }

        public void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public void Hello()
        {
            Console.WriteLine(string.Format("Hello my name is {0}. I am {1} years old", LocalName, Age));
        }

        public static bool Compare(string nameOne, string nameTwo)
        {
            return nameOne.Equals(nameTwo);
        }

    }
}
