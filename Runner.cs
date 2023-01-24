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
            Andrew.Hello(David);
            Console.WriteLine($"{Andrew.Gender} - {David.Gender}");

            int x = 100;

            while (x < 100)
            {
                Console.WriteLine(++x);
            }

            x = 100;
            do
            {
                Console.WriteLine(++x);
            } while (x < 100);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            
            while (true)
            {
                Console.ReadLine();
                // Logic 

                // if allowed.
                break;
            }

            bool allowPass = false
            while (!allowPass)
            {
                Console.ReadLine();
                // Logic 

                // if allowed.
                allowPass = true
            }
            Console.ReadLine();
        }

    }
}
