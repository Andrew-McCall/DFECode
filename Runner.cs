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
            int win1 = 42, win2 = 1, win3 = 5, win4 = 49, win5 = 33, win6 = 34;   
      
            string lotteryNumbers = string.Format("The winning lottery numbers are {4}, {1}, {2}, {3}, {4}, {5}", win1, win2, win3, win4, win5, win6);      // 11)           
            
            string two = $"blah {win1}, {win2 + win3}"; // String literal
            
            Console.WriteLine(lotteryNumbers);
            Console.WriteLine(two);

            VariablesClass vc = new VariablesClass();

            Console.WriteLine("|Y|");

            vc.DoY();
            vc.DoY();

            Console.WriteLine("|Z|");

            vc.DoZ();
            vc.DoZ();
            vc.DoZ();
            vc.DoZ();

            Console.ReadLine();
            // 0,1 0,1
            // 1,2

            

        }

    }
}
