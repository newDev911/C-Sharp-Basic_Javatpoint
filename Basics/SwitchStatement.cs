using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_JavaTpoint
{
    class SwitchStatement
    {
        public void findNumber()
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("NUmber is 20");
                    break;
                case 30:
                    Console.WriteLine("Number is 30");
                        break;
                default:
                        Console.WriteLine("Number is not 10, 20 or 30");
                        break;
            }
        }
    }
}
