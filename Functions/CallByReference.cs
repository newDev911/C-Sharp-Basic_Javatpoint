using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Functions
{
    class CallByReference
    {
        // 'ref' keyword is used to pass argument as refernce-type. 
        // It passess reference of arguments to the function rather than copy of original value.
        // The changes in passed value will be permanant and MODIFY THE ORIGINAL VALUE.

        public void callByReferenceExample(ref int val) // 'ref' keyword is important
        {
            int square = 5;
            val = square;
            val *= val;
            Console.WriteLine("Value of 'val' inside our function: {0}", val);
        }
    }
}
