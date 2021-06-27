using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Arrays
{
    // Multidimensional array is also known as rectangular array in C#. It can be two or three dimensional
    // The data is stored in tabular form (row * column) which is also known as 'Matrix'
    
    public static class MultiDimensional_Array_Example
    {
        // To create we need to use Comma ',' inside the square brackets.
        public static void Array_2D(int[,] arr)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
        }

        // There are 3 ways to initialize MultiDimensional Array
        // 1:
        static int[,] arr = new int[3, 3]{ {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        // * new int[Index, Number of pieces of data]

        // 2:  (We can Omit the array size)
        static int[,] arr1 = new int[,] { { 7, 8, 9 }, { 6, 5, 4 }, { 3, 2, 1 } };

        // 3: (We can also omit the 'new' keyword)
        static int[,] arr2 = { { 11, 22, 33 }, { 44, 55, 66 }, { 77, 88, 99 } };

        public static void multiDimensional_Array(int[,] arr3)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }  
        }

        public static void stringMultiDimensional_Array(string[,] arr4)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr4[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
