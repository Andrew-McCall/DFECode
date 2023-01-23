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

            this.Gender = "N/A";
        }

        private void Funny()
        {
            Console.WriteLine("A fish swam into a concrete wall, He said Dam!");
        }

        public void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public void Hello()
        {
            Console.WriteLine(string.Format("Hello, {0}. I am {1} years old", this.LocalName, this.Age));
        }

        public static bool Compare(string nameOne, string nameTwo)
        {
            return nameOne.Equals(nameTwo);
        }

    }
}
