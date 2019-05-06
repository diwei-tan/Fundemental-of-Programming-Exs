using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class HProb8
    {
        static void Main()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Please input new size of array: ");
            int newSize = int.Parse(Console.ReadLine());
            int[] B = new int[newSize]; //must always initialize with size
            B = ResizeArray(A, newSize);
            PrintArray(B);
            Console.WriteLine("Length of new array is now {0}", B.Length);
        }
        static void PrintArray(int[] x)
        {
            Console.Write("[");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(" {0}", x[i]);
                if (i < x.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine(" ]");
        }
        static int[] ResizeArray(int[] x, int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < x.Length; i++)
            {
                newArray[i] = x[i];
            }
            return newArray;
        }
    }
}
