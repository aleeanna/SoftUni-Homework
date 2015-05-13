using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHWProblem4._1
{
    class EqualStrings
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split(' ');

            // Use Array.FindAll to check one by one (or in a loop) if there are any strings that are 
           // the same as each of the array elements. Then include those in another array and compare the lengths of arrays.
            //Print hte largest array, or if more than one have the same length - leftmost(first result).

            string[] stuff = { "Monday", "monday", "Tuesday", "Wednesday", "Wednesday", "Wednesday", "Monday" };

            string[] matched = null;

            for (int i = 0; i < stuff.Length; i++)
            {
                matched = Array.FindAll(stuff, element => element == stuff[i]);

                if (Array.FindAll(stuff, element => element == stuff[i]) == null)
                {
                    continue;
                }
            }

            foreach (string match in matched)
            {
                Console.WriteLine(match);
            }
        }
    }
}
