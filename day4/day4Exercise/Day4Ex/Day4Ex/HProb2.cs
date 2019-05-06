using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class HProb2
    {
        static void Main()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            PrintArray(A);
        }
        static void PrintArray (int[] x)
        {
            Console.Write("[");
            for (int i=0; i < x.Length; i++)
            {
                Console.Write(" {0}", x[i]);
                if (i < x.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine(" ]");
        }
    }
}
