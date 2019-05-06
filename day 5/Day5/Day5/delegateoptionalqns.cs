using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class delegateoptionalqns
    {
        delegate double DoubleOps(double x);
        static void Main()
        {
            double[] x = new double[] { 1.0, 2.0, 3.0, 4.0 };
            PrintArray(x);
            double[] y = new double[x.Length];
            x.CopyTo(y, 0);
            PrintArray(y);
            double[] z = new double[x.Length];
            x.CopyTo(z, 0);
            PrintArray(z);
            DoubleOps delegateOps = Sqrt;
            ProcessArray(y, delegateOps);
            delegateOps = Square;
            ProcessArray(z, delegateOps);
            PrintArray(x);
            PrintArray(y);
            PrintArray(z);
        }
        //Method that uses a delegate as input! Possible as delegate is treated as a object instead of class!
        static void ProcessArray(double[] arr, DoubleOps ops)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ops(arr[i]);
            }
        }
        static void PrintArray(double[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]:0.###}");
                if (i != arr.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine(" ]");
        }
        //method for delegate to callback
        static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        static double Square(double x)
        {
            return x * x;
        }

    }
}
