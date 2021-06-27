using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Arrays
{
    // 'Jagged Array' is also known as 'array of arrays' because its elements are arrays
    // The element size of Jagged Array can be different.

    public static class JaggedArrayaExample
    {
        public static void JaggedExample1(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");   
                }
                Console.WriteLine();
            }
        }

        public static void JaggedExample2(int[][] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j] + " ");       
                }
                Console.WriteLine();
            }
        }
    }
}
