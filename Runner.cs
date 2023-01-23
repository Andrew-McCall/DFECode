using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFECSharp
{
    class Runner
    {

        public static void Main(string[] args)
        {

            Person David = new Person("David", 20);
            David.Hello();
            David.Hello("McCall");

            Person Andrew = new Person("Andrew",18, "Male");
            Andrew.Hello();
            Console.WriteLine($"{Andrew.Gender} - {David.Gender}");
            
            //David.LocalName = "Not Andrew";
            //David.HelloSelf();

            /// Make new class. 


            // private void
            //   - Console.WriteLine something funny

            // public void
            //   - Say's hello to a person saved privatley (string variable)


            /// Run it from main. 
            // ClassName name = new ClassName();
            // name.property = x;
            // name.SayHello();


            /// Extension
            // public static boolean
            //   - Compare Two given names


            /// Extension 2
            // public function. public property (variable of the class). 

            Console.ReadLine();
        }

    }
}
