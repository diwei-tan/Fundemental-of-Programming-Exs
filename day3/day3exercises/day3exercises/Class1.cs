using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3exercises
{
    class Class1
    {
        static void Main()
        {
            /* for loop lesson
            Console.Write("Please input size: ");
            int size = int.Parse(Console.ReadLine());
            for (int x = 1; x <= size; x++)
            {
                for (int i = 1; i <= x; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            */

            /*Reverse the string:
            string input = "Hello World";

            //output string woudl have same length as original string
            //look from index = 0 to length of string -1
            //copy char from end of string to front
            // copy ith char starting from end of string

            int len = input.Length;
            string output = "";

            for (int index=0; index<= len-1; index++)
            {
                output = output + input.Substring(len - 1 - index, 1).ToUpper(); //can add many properties
            }
            Console.WriteLine(output);

            */

            // string.Split()

            string s = "institute     of     systems     science";
            string output = "";

            string[] sArr = s.Split(); //splits sentence into its words based of separator (default is ' ')

            //if multiple ' 'es, each additional ' ' after a ' ' (alternate ' ') will be treated as an element!!!!

            //Create empty output string
            //look through sArr[] and if element is not ' ' append to the output
            for (int i = 0; i< sArr.Length; i++)
            {
                if (sArr[i] != "")
                    output = output + sArr[i] + " ";
            }

            output = output.Trim();
            Console.WriteLine(output);

            
        }
    }
}
