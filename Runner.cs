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

            /// A collection of data. A changable amount of differnt data. (Interface)

            // Lists
            int[] myArray = new int[0]; // Array (Part of c#)
            List<int> myList = new List<int>();

            // Dictionarys 
            // Key-Value Pairs
            // "Red"  : "#FF0000"
            // "Blue" : "#0000FF"
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("Red", "#FF00000");

            // Set
            SortedSet<int> mySortedSet = new SortedSet<int>();
            HashSet<int> myHashSet = new HashSet<int>();

            // Queue
            Queue<int> myQueue = new Queue<int>();

            // Stack
            Stack<int> myStack = new Stack<int>();






            /// 10 Min break. 10:20 

            // Lists and Collections

            // 2 Player Naughts and Crosses 
            // List
            // (Enum)
            // Loops
            // Logic - if/switch

            // Prasing/Input

            Console.ReadKey();

        }

    }
}
