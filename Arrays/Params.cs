using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Arrays
{
    // PARAMS KEYWORD:
    // Params is a keyword which is used to specify a parameter that takes variable number of arguments. 
    // It is useful when we don't know the number of arguments prior. 
    // Only one param keyword is allowed and no additional parameter is permitted after params keyword in a function declaration.
    static class ParamsExample
    {
        public static void paramExample1(params int[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }

        public static void paramsExample2(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
