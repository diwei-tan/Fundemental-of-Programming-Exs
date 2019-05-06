using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class Prob2 // Test other sorting methods too!
    {
        static void Main()
        {
            int[] A = new int[] { 8, 5, 7, 3, 1, 2, 9, 0, 4, 6 };
            PrintIntArray(A); // show original first
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] < A[j])
                    {
                        Swap(A, i, j);
                        PrintIntArray(A);
                    }
                }
            }           
        }

        static void Swap(int[] x, int a, int b)
        {
            int temp = x[a];
            x[a] = x[b];
            x[b] = temp;
        }

        static void PrintIntArray(int[] x)
        {
            Console.Write("[ ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]);
                if (i < (x.Length - 1))
                    Console.Write(", ");
            }
            Console.WriteLine(" ]");
        }
    }
}
