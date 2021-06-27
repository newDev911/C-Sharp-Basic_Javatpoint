using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_JavaTpoint
{
    class ForLoopStatement
    {
        public void loopExample()
        {
            Console.WriteLine("Enter length of loop");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Loop: " + i);
            }
        }
        public void nestedLoopExample()
        {
            Console.WriteLine("Enter Parent Loop Length");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Inner Loop Length");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    Console.WriteLine("Parent Loop: {0} - Child Loop: {1}", i, j);
                }
            }
        }

        public void infiniteLoop()
        {
            for (; ; )
            {
                Console.WriteLine("Infinite Loop");
            }
        }
    }
}
