using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class HProb10
    {
        static void Main()
        {
            int[,] A = new int[4, 2] {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
                { 7, 8 }
            };
            int[,] B = new int[2, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            int[,] C = new int[A.GetLength(0), B.GetLength(1)];
            C = MatrixMultiply(A, B);
            PrintArray(C);
        }

        static int[,] MatrixMultiply(int[,]A, int[,] B)
        {
            int[,] x = new int[A.GetLength(0), B.GetLength(1)];
            for(int i=0; i<A.GetLength(0); i++)
            {
                for(int j=0; j < B.GetLength(1); j++)
                {
                    int nodeSum = 0;
                    for (int k=0; k< A.GetLength(1); k++)
                    {
                        nodeSum = nodeSum + A[i, k] * B[k, j];
                    }
                    x[i, j] = nodeSum;
                }
            }
            return x;
        }

        static void PrintArray(int[,] x)
        {
            for (int i=0; i<x.GetLength(0); i++)
            {
                for(int j=0; j<x.GetLength(1); j++)
                {
                    Console.Write($"{x[i, j]}\t");
                    if (j == x.GetLength(1) - 1)
                        Console.WriteLine("");
                }
            }
        }
    }
}
