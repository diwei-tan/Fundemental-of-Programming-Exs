using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class Prob7
    {
        static void Main()
        {
            string[] name = new string[] { "Alice", "Bob", "Charlie", "Dennis", "Eli", "Frank", "Gina" };
            int[] score = new int[] { 100, 90, 120, 80, 76, 66, 88 };
            for (int i = 0; i < score.Length - 1; i++)
            {
                for (int j = i + 1; j < score.Length; j++)
                {
                    if (score[i] > score[j])
                    {
                        SwapName(name, i, j);
                        SwapScore(score, i, j);
                    }

                }
            }
            // Print
            PrintArray(name, score);
        }
        static void SwapScore(int[] x, int a, int b)
        {
            int temp = x[a];
            x[a] = x[b];
            x[b] = temp;
        }

        static void SwapName(string[] x, int a, int b)
        {
            string temp = x[a];
            x[a] = x[b];
            x[b] = temp;
        }

        static void PrintArray(string[] x, int[] y)
        {
            Console.Write("Name\t\t");
            Console.WriteLine("Score");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{x[i]}\t\t{y[i]}");
            }
        }
    }
}
