using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_JavaTpoint
{
    class WhileLoopStatement
    {
        public void whilLoopExample()
        {
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine("Loop - {0}", i);
                i--;
            }
        }
        public void nestedLoopExample()
        {
            Console.WriteLine("Enter Parent Loop Length");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Child Loop Length");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int n1 = 0;
            while(n1 < num1){
                int n2 = 0;
                while (n2 < num2)
                {
                    Console.WriteLine("Parent Loop: {0} -- Child Loop: {1}", n1, n2);
                    n2++;
                }
                        n1++;
            }
        }

        public void infiniteLoopExample()
        {
            while (true)
            {
                Console.WriteLine("Infinite Loop");
            }
        }
    }
}
