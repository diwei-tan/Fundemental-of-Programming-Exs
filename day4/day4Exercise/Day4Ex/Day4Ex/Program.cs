using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Section G
            //Problem 4
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("[ ");
            for(int i=0; i<A.Length; i++)
            {
                Console.Write(A[i]);
                if (i < (A.Length - 1))
                    Console.Write(", ");
            }
            Console.WriteLine(" ]");
        }
    }
}
