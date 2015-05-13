using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExamples
{
    class ArraysExamples
    {
        static void Main(string[] args)
        {
            //string[] array = { "one", "two", "three", "four" };
            //for (int index = 0; index < array.Length; index++)
            //{
            //    // Print each element on a separate line
            //    Console.WriteLine("Element[{0}] = {1}", index, array[index]);
            //}

            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //Console.Write("Output: ");
            //for (int index = 0; index < array.Length; index++)
            //{
            //    // Doubling the number
            //    array[index] = 2 * array[index];
            //    // Print the number
            //    Console.Write(array[index] + " ");
            //}
            //Console.WriteLine();
            //// Output: 2 4 6 8 10


            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //Console.Write("Output: ");
            //for (int index = 0; index < array.Length; index+=2)
            //{
            //    // Changing only the values at 0, 2 and 4th position in the array
            //    array[index] = array[index] * array[index];
            //    // Print the number
            //    Console.Write(array[index] + " ");
            //}
            //Console.WriteLine();
            //// Output: 1 9 25

            //Length of an array starts counting from 1, whereas indexes in the array begin from 0!!!

            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //Console.Write("Reversed: ");

            //for (int index = array.Length - 1; index >= 0; index--)
            //{
            //    Console.Write(array[index] + " ");
            //}
            //// Reversed: 5 4 3 2 1

            //// Declare and initialize a matrix of size 2 x 4
            
            //int[,] matrix =
            //    {
            //        {1, 2, 3, 4}, // row 0 values
            //        {5, 6, 7, 8}, // row 1 value
            //    };
            //// Print the matrix on the console
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            Console.Write("Enter the number of the rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the columns: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Enter the cells of the matrix:");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }



        }
    }
}
