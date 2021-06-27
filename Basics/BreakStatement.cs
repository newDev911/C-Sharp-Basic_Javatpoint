using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Basics
{
    class BreakStatement
    {
        public void BreakLoopExample()
        {
            Console.WriteLine("Break loop on number:");
            int inp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < 100; i++)
            {
                if (i == inp1)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        public void BreakInNestedLoop()
        {

            Console.WriteLine("Enter Parent Loop Length:");
            int inp1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Child Loop Length:");
            int inp2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Break Parent Loop On Number:");
            int inp3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Break Child Loop On Number:");
            int inp4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < inp1; i++)
            {
                for (int j = 0; j < inp2; j++)
                {
                    if (i == inp3 && j == inp4)
                    {
                        break;
                    }
                    Console.WriteLine("Parent Loop: {0} - Child Loop: {1}", i, j);
                }
            }
        }
    }
}
