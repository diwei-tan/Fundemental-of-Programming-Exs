using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class Prob1
    {
        static void Main()
        {
            int[] sales = new int[] { 123, 125, 500, 300, 76, 145, 654, 780, 96, 101, 345, 2346 };
            PrintMaxSales(sales);
            PrintMinSales(sales);
            PrintAveSales(sales);
        }

        static void PrintMaxSales(int[] x)
        {
            int maxPos = 0; // Set max as the first array value first
            for (int i=1; i < x.Length; i++)
            {
                if (x[maxPos] < x[i])
                {
                    maxPos = i;
                }
            }
            Console.WriteLine("Max sales occured in month {0}", maxPos);
        }

        static void PrintMinSales(int[] x)
        {
            int minPos = 0; // Set min as the first array value first
            for (int i = 1; i < x.Length; i++)
            {
                if (x[minPos] > x[i])
                {
                    minPos = i;
                }
            }
            Console.WriteLine("Min sales occured in month {0}", minPos);
        }

        static void PrintAveSales(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum = sum + x[i];
            }
            double ave = (double)sum / x.Length;
            Console.WriteLine($"Ave sales was {ave:$,0.##}");
        }
    }
}
