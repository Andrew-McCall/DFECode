using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFECSharp
{
    class Runner
    {
           
        public void DoY()
        {
            int x = 10; // Scope To this function
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World One");
            Console.WriteLine("Hello World Two");
            Console.ReadLine();

            // Whole Numbers
            int int32 = 10; 
            long bit64 = 99; 

            // Decimal numbers
            decimal digits16b = 0.1M;
            double digits8b = 0.1;
            float digitst4b = 0.1f;

            string text = "Text";
            char character = 'a';

            bool boolean = true;

            // An array
            int[] array = new int[] {1,2,3,4,5};

            array[4] = 5 + 1;
            array[5] = 60;

            // ArrayLists
            List<int> lisst = new List<int>() {1,2,3,4,5};
            lisst.Add(60);

            // 2d array
            int[][] d2array = new int[1][];
            int[,] d2arrayJ = new int[1,1];

        }

    }
}
