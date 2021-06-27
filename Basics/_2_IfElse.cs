using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_JavaTpoint
{
    class _2_IfElse
    {
        public void findEvenNumber()
        {
            // IF EXAMPLE:
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine("It's An Even Number");
            }
        }
        public void findEvenOddNumber()
        {
            // IF-ELSE EXAMPLE:
            int num1 = 11;
            if (num1 % 2 == 0)
            {
                Console.WriteLine("It's an EVEN number");
            }
            else
            {
                Console.WriteLine("It's an ODD number");
            }
        }
        public void userInputIfElse()
        {
            Console.WriteLine("Enter a number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            else
            {
                Console.WriteLine("It is odd number");
            }
        }
        public void findGrade()
        {
            Console.WriteLine("Enter a number to check grade");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num3 < 0 || num3 > 100){
                Console.WriteLine("Wrong Number");
            }
            else if (num3 >= 0 && num3 < 50)
            {
                Console.WriteLine("Fail!");
            }
            else if (num3 >= 50 && num3 < 60){
                Console.WriteLine("D Grade!");
            }
            else if (num3 >= 60 && num3 < 70) {
                Console.WriteLine("C Grade!");
            }
            else if (num3 >= 70 && num3 < 80)
            {
                Console.WriteLine("B Grade!");
            }
            else if (num3 >= 80 && num3 < 90)
            {
                Console.WriteLine("A Grade!");
            }
            else if (num3 >= 90 && num3 <= 100)
            {
                Console.WriteLine("A+ Grade!");
            }
        }
    }
}
