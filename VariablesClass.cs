using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFECSharp
{
    class VariablesClass
    {

        private int x = 0;
        int y = 1;

        public void DoY()
        {
            int x = 0;
            Console.WriteLine(x.ToString());
            x++;
            int y = x; // Passes value
            Console.WriteLine(y.ToString());
        }

        public void DoZ()
        {
            x++;
            Console.WriteLine(x.ToString());
        }


    }

}
