using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[input.Length];

            for (int count = 0; count < nums.Length; count++)
            {
                nums[count] = int.Parse(input[count]);

                //int sum = nums[count] + nums[count + 1];
                //int nextSum = nums[count + 2] + nums[count + 3];

                //if (sum == nextSum)
                //{
                //    Console.WriteLine("Yes, value= " + sum);
                //}
            }

        }
    }
}
