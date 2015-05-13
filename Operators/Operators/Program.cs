using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 35;
            int b = 5;
            int c = 7;
            
            int remainderA = a%b;
            int remainderB = a%c;
            bool result = (remainderA == 0) && (remainderB == 0);
            if(result == true)
            {
                Console.WriteLine(a + " is divisible by both 5 and 7.");
            }
            else
            {
                Console.WriteLine(a + " is not divisible by bothe 5 and 7.");
            }
        }
    }
}
