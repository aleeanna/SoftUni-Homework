using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHWProblem4
{
    class MinMaxAvg
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] nums = new double[n];
            List<int> whole = new List<int>();
            List<double> notWhole = new List<double>(); 

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter nums[{0}] = ", i);
                nums[i] = double.Parse(Console.ReadLine());

                if(nums[i]%1 == 0)
                {
                    whole.Add((int)nums[i]);
                }
                else
                {
                    notWhole.Add(nums[i]);
                }
            }

            Console.Write("[ ");

            foreach (int num in whole)
            {
                Console.Write(string.Join(", ", whole));
            }

            Console.Write("[ ");

            Console.Write(" -> ");
            Console.Write("min: {0}, max: {1}, sum: {2}, avg: {3:F2}", 
                whole.Min(), whole.Max(), whole.Sum(), whole.Average());

            Console.Write("[ ");

            foreach (int num in notWhole)
            {
                Console.Write(string.Join(", ", notWhole));
            }

            Console.Write("[ ");

            Console.Write(" -> ");
            Console.Write("min: {0}, max: {1}, sum: {2}, avg: {3:F2}", 
                notWhole.Min(), notWhole.Max(), notWhole.Sum(), notWhole.Average());
        }
    }
}
