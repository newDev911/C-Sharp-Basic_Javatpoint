using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Arrays
{
    // C# provides an array class to deal with array related operations. It provides methods for creating, manipulating, searching and sorting elements of an array.
    
    public static class ArrayClassExample
    {
        public static void arrayLength(int[] arr)
        {
            Console.WriteLine("Length of array is: {0}", arr.Length);
        }

        public static void arraySort(int[] arr)
        {
            Console.WriteLine("Unsorted Array: ");
            arrayPrintElemets(arr);
            Array.Sort(arr);
            Console.WriteLine("\nSorted Array:");
            arrayPrintElemets(arr);
        }
        public static void arrayIndexOf(int[] arr)
        {
            Console.WriteLine("Array Elements: ");
            arrayPrintElemets(arr);

            Console.WriteLine("Find Index of: ");
            int findIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Index of '{0}' is : {1}", findIndex,  Array.IndexOf(arr, findIndex));
        }

        public static void arrayCopy(int[] arr, int[] arr2)
        {

            Console.WriteLine("Array elements of arr2 before: ");
            arrayPrintElemets(arr2);

            Array.Copy(arr, arr2, arr.Length);

            Console.WriteLine("Array elements of arr2 after Copy: ");
            arrayPrintElemets(arr2);
        }

        public static void arrayRevers( int[] arr)
        {
            Console.WriteLine("Array Sorted Order: ");
            Array.Sort(arr);
            arrayPrintElemets(arr);

            Console.WriteLine("Reverse Order array: ");
            Array.Reverse(arr);
            arrayPrintElemets(arr);
        }


        public static void arrayPrintElemets(int[] arr)
        {
            foreach (Object i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
