using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Basics
{
    class GoToStatement
    {
        // GOTO Statement also known as jump statement
        // It is used to transfer control to the other part of program.
        // It unconditionally jumps to the specific label.

        // It can be used to transfer control from deeply nested loop or switch case label.

        public void gotoExample()
        {
            ineligible: // GoTo Point
                Console.WriteLine("\nYou're not eligible");

            Console.WriteLine("\nEnter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("\nYou're eligible to vote");
            }

        }
    }
}
