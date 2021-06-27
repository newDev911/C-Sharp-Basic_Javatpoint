using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Basics
{
    class ContinueStatement
    {
        // It continues the flow of program and skips the remaining code at the specific condition.
        // In case of INNER loop, it continues only INNER loop

        public void continueExample()
        {
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue; // Skips 3
                }
                Console.WriteLine("Number : {0}", i);
            }
        }

        public void continueWithInnerLoop()
        {
            Console.WriteLine("Write Parent Loop Length:");
            int inp1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Child Loop Length:");
            int inp2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Continue Parent Loop on : ");
            int inp3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Continue Child Loop on : ");
            int inp4 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < inp1; i++)
            {
                for (int j = 0; j < inp2; j++)
                {
                    if (i == inp3 && j == inp4)
                    {
                        continue;
                    }
                    Console.WriteLine("Parent Loop: {0} - Child Loop: {1}", i, j);
                }
            }
        }
    }
}
