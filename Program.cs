using CSharp_JavaTpoint.Basics;
using CSharp_JavaTpoint.Functions;
using CSharp_JavaTpoint.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_JavaTpoint
{
    class Program
    {
        static void Main(string[] args)
        {
          _2_IfElse obj1 = new _2_IfElse();
          SwitchStatement obj2 = new SwitchStatement();
          ForLoopStatement obj3 = new ForLoopStatement();
          WhileLoopStatement obj4 = new WhileLoopStatement();
          DoWhileLoopStatement obj5 = new DoWhileLoopStatement();
          BreakStatement obj6 = new BreakStatement();
          ContinueStatement obj7 = new ContinueStatement();
          GoToStatement obj8 = new GoToStatement();
          FunctionsExamples obj9 = new FunctionsExamples();
          CallByValueFunctionExample obj10 = new CallByValueFunctionExample();
          CallByReference obj11 = new CallByReference();
          OutParamterInFunctions obj12 = new OutParamterInFunctions();
          ArrayExamples obj13 = new ArrayExamples();
          ArrayInFunctionsExample obj14 = new ArrayInFunctionsExample();
          
            
            
            //obj1.findEvenNumber();
          //Console.WriteLine("-------");
          //obj1.findEvenOddNumber();
          //Console.WriteLine("-------");
          //obj1.userInputIfElse();
          //Console.WriteLine("-------");
          //obj1.findGrade();

          //obj2.findNumber();

          //obj3.loopExample();
          //Console.WriteLine("-------");
          //obj3.nestedLoopExample();
          //Console.WriteLine("-------");
          //obj3.infiniteLoop();

          //obj4.whilLoopExample();
          // obj4.nestedLoopExample();
          //obj4.infiniteLoopExample();

          //obj5.numto5();
          //obj5.nestDoWhile();
          //obj5.infiniteLoop();

          //obj6.BreakLoopExample();
          //obj6.BreakInNestedLoop();

          //obj7.continueExample();
          //obj7.continueWithInnerLoop();

          //obj8.gotoExample();

          //obj9.functionUsingNoParameter_or_ReturnType();
          //obj9.functionUsingParamter_no_ReturnType("Hello World");
          //string msg1 = obj9.functionWithParameterAndReturnType("Hello Admin!");
          //string msg2 = obj9.functionWithParameterAndReturnType("Hello User!");
          //Console.WriteLine("msg1 value is:  {0}", msg1);
          //Console.WriteLine("msg2 value is:  {0}", msg2);

          //int val = 10;
          //Console.WriteLine("Value of 'val' before calling the function: {0}", val);
          //obj10.callByValue(val);
          //Console.WriteLine("Value of 'val' after calling the function: {0}", val);

          //int val = 4;
          //Console.WriteLine("Value of 'val' before calling function: {0}", val);
          //obj11.callByReferenceExample(ref val); // 'ref' keyword is important
          //Console.WriteLine("Value of 'val' after calling function: {0}", val);

          //int val = 50;
          //Console.WriteLine("Value of 'val' before passing 'out' varible: {0}", val);
          //obj12.outParameterExample1(out val); // 'out' keyword is required
          //Console.WriteLine("Value of 'val' after getting 'out' variable value: {0}", val);

          //int val1 = 50, val2 = 100;
          //Console.WriteLine("Values before calling 'out' variables: val1 = {0} -- val2 = {1}", val1, val2);
          //obj12.outParameterExample2(out val1, out val2);
          //Console.WriteLine("Values after calling 'out' variables: val1 = {0} -- val2 = {1}", val1, val2);
            /*
            ** Behind the scene 'ref' & 'out' both have same implementation.
             The only difference is how the compiler tracks whether variable are assigned or not.
            */

          //obj13.singleDimensionalArray();
          //obj13.arrayExample2();
            /*
          int[] arr1 = { 2, 4, 5, 7, 8, 7 };
          obj14.arrayToFunction1(arr1);// Print Array
           obj14.printMinNumInArray(arr1); // Print min value in array
          obj14.printMaximumNum(arr1); // Print Max Value in Array    
             */

            /*
            //              ** new int[number of rows, number of pieces of data]
          int[,] arr = new int[5 ,5];
          arr[0, 0] = 10;//initialization  
          arr[1, 1] = 20;
          arr[2, 2] = 30;
          arr[3, 3] = 50;
          arr[4, 4] = 60;  
          MultiDimensional_Array_Example.Array_2D(arr);
            
            int[,] arr1 = { { 11, 22, 33 }, { 44, 55, 66 }, { 77, 88, 99 } };
          MultiDimensional_Array_Example.multiDimensional_Array(arr1);
            */

            /*
          var namelist = new string[4, 2]{
              {"Dane", "20y"},
              {"John", "22y"},
              {"Mike", "12y"},
              {"Kate", "32y"}
          };

          MultiDimensional_Array_Example.stringMultiDimensional_Array(namelist);
          Console.WriteLine("----------------------------------------");
          Console.WriteLine("GETTING SINGLE DATA");
          Console.WriteLine(namelist[1, 0]);
            */


             // JAGGED ARRAYS:
            // DECLARATION EXAMPLES:
            // Ex: 1
            /*
            int[][] arr = new int[2][];// Declare the array  
            arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
            arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

            JaggedArrayaExample.JaggedExample1(arr);
            */

            /*
            // Example: 2
            // Intializes the Jagged Array while declaration
            int[][] arr2 = new int[3][]{
                new int[] {2, 3, 5, 6},
                new int[] {4, 2, 5, 1, 7},
                new int[] {5, 7, 3, 7, 3, 3, 6}
            };

            JaggedArrayaExample.JaggedExample2(arr2);
            Console.WriteLine("---------------------------");
            Console.WriteLine("GETTING SINGLE ELEMENT");
            Console.WriteLine(arr2[1][2]); // Print 5
            */
            /*
          ParamsExample.paramExample1(2, 4, 5, 6, 7, 8);

          ParamsExample.paramsExample2("David", 2, 'C', 33.4);
            */

            int[] arr1 = new int[6] {2, 7, 9, 5, 3, 1};
            int[] arr2 = new int[6];

            //ArrayClassExample.arrayLength(arr1);
            //ArrayClassExample.arraySort(arr1);
            //ArrayClassExample.arrayIndexOf(arr1);
            //ArrayClassExample.arrayCopy(arr1, arr2);
            ArrayClassExample.arrayRevers(arr1);

            Console.ReadKey();

        }
    }
}
