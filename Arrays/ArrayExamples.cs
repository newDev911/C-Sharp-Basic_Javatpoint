using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Arrays
{
        // There are 3 types of arrays:
        //      1 - Single Dimensional Array
        //      2 - MultiDimensional Array
        //      3 - Jagged Array
    class ArrayExamples
    {
        // 1
        public void singleDimensionalArray()
        {
            int[] arr = new int[5]; // Array of length of 5
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        } 

        // Declaration & Initialization At same time
        public void arrayExample2()
        {
            int[] arr = new int[5] { 5, 6, 7, 8, 9 };

            // Or we can ommit the size of array
            int[] arr1 = new int[]{7, 5, 4, 6, 1};

            // Or we can ommit 'new' operator also
            int[] arr2 = { 3, 4, 5, 7, 9, 0 };

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("-------------------");

            Console.WriteLine("For Each Example");
            // Or we can 'Traverse' the array elements using 'foreach' loop
            foreach (int j in arr1)
            {
                Console.WriteLine(j);
            }
        }
    }
}
