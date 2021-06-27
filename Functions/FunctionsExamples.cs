using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Functions
{

    // Function consists of following components:
    // Function Name: Unique name used to make function call
    // Return Type: Used to specify the Data Type of function Return Value
    // Body: Contains executable code
    // Access Specifier: Used to specify function Accessibility in the application.
    // Parameters: List of arguments that we can pass while calling our function.
    class FunctionsExamples
    {
        // User defined function without 'return type'
        public void functionUsingNoParameter_or_ReturnType()// No parameter
        {
            Console.WriteLine("Function with no parameter or return type");
        }

        // Using parameter without return type
        public void functionUsingParamter_no_ReturnType(string msg)
        {
            Console.WriteLine("Parameter value is :{0}", msg);
        }

        // Using paramter and return type
        public string functionWithParameterAndReturnType(string msg)
        {
            //Console.WriteLine("Your Message: {0}", msg);
            return msg;
        }

    }
}
