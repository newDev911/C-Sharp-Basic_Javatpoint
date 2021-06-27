using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Functions
{
    // Value Type paramters are:
    // That pass a copy of original value to the function rather than reference.
    //  It doesn't modify the original value.
    //  A change made in passed value doesn't alter the actual value.
    class CallByValueFunctionExample
    {
        public void callByValue(int val)
        {
            val *= val;
            Console.WriteLine("Value inside our function: {0}", val);
        }
    }
}
