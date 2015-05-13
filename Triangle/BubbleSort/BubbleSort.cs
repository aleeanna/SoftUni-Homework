using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            bool swapped = false;

            do
            {
                for (int i = 1; i < nums.Length*nums.Length; i++)
                {
                    if (i + 1 < nums.Length && nums[i] > nums[i + 1])
                    {
                        nums[i] = SwapElements(nums[i], nums[i + 1]);
                        swapped = true;
                    }
                }
            }while (swapped);
            
        }

        private static int SwapElements(int leftElement, int rightElement)
        {
            leftElement = leftElement + rightElement;
            rightElement = leftElement - rightElement;
            leftElement = leftElement - rightElement;

            return leftElement;
        }
    }
}
