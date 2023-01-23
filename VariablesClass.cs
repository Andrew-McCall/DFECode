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
        int z = -1;

        protected int w = 10; // private + some special sub stuff

        public int y = 1; // everyone has access
        public int s { set; get; } = 0;

        public int t { private set; get; } = 0;
        public int set { set; protected get; } = 0;

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

        public static bool Compare(int a, int b)
        {
            return a == b;
        }

    }

}
