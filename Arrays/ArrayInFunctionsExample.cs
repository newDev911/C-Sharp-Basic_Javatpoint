using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Arrays
{
    // To pass Array to Function, we need to provide only array name
    class ArrayInFunctionsExample
    {
        public void arrayToFunction1(int[] arr)
        {
            Console.WriteLine("Printing Array Elements");
            for (int i = 0; i< arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        // Print Minimum Number
        public void printMinNumInArray(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum Element is: {0}", min);
        }

        public void printMaximumNum(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum value is: {0}", max);
        }
    }
}
