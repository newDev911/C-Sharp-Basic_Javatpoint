using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Functions
{
    // 'out' keyword is used to pass argument as out-type. 
    // It is like reference type, except that it doesn't require variable to initialize before passing.
    // It is useful when we want a function to return multiple values

    // The use of 'out' parameter is when we don't initialize variable value in our main function and we expect another function to set value of that variable.
    class OutParamterInFunctions
    {
        public void outParameterExample1(out int val) //'out' keyword is required
        {
            int square = 5;
            val = square;
            val *= val;
        }

        public void outParameterExample2(out int a, out int b)
        {
            int square = 5;
            a = square;
            b = square;

            a *= a; // a = a*a
            b *= b;
        }
    }
}
