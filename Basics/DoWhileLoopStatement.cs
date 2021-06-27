using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint.Basics
{
    class DoWhileLoopStatement
    {
        public void numto5()
        {
            int i = 1;
            do{
            Console.WriteLine(i);
            i++;
            }while(i <= 5);
        }

        public void nestDoWhile()
        {
            Console.WriteLine("Enter Parent Loop Length:");
            var inp1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Inner Loop Length");
            var inp2 = Convert.ToInt32(Console.ReadLine());

            int i =  1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine("Parent Loop: {0} - Child Loop: {1}", i, j);
                    j++;
                } while (j <= inp2);
                i++;
            } while (i <= inp1);
        }

        public void infiniteLoop()
        {
            do
            {
                Console.WriteLine("Infinite Loop");
            } while (true);
        }
    }
}
