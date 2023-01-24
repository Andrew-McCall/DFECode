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

            Months currentMonth = Months.Jul;
            Day today = (Day)5;
            
            Console.WriteLine(today);

            if (currentMonth == Months.Jul)
            {
                Console.WriteLine("Jul");
                Console.WriteLine(currentMonth);
            }

            switch (currentMonth)
            {
                case Months.Mar:
                    Console.WriteLine("Mar");
                    break;

                case Months.Jun:
                    Console.WriteLine("Jun");
                    break;
            }


            Console.ReadKey();

        }

    }
}
