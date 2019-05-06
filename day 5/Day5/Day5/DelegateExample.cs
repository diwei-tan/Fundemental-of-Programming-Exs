using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class DelegateExample
    {
        delegate int IntOps(int n);
        static void Main()
        {
            int[] x = new int[] { 1, 2, 3, 4, 5 };
            PrintArray(x);
            IntOps delegateOps = Add10;
            x[0] = delegateOps(x[0]);
            PrintArray(x);
            ApplyOperation(x, delegateOps);
            PrintArray(x);
        }
        //Method that uses a delegate as input! Possible as delegate is treated as a object instead of class!
        static void ApplyOperation (int[] arr, IntOps ops)
        {
            for (int i=0; i < arr.Length; i++)
            {
                arr[i] = ops(arr[i]);
            }
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i=0; i <arr.Length; i++)
            {
                Console.Write(" {0}", arr[i]);
                if (i != arr.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine(" ]");
        }
        //method for delegate to callback
        static int Add10(int x)
        {
            return (x + 10);
        }

    }
}
