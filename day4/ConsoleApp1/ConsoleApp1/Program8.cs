using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program8
    {
        static void Main()
        {
            //int[] A = new int[] { 1, 2, 3 };
            //Increment(A);
            //for(int y=0; y < A.Length; y++)
            //{
            //    Console.WriteLine(A[y]); //Note: the value change because Array is a reference type and not a value
            //}

            //passing array (ref type) by reference
            int[] A = new int[3];
            Console.WriteLine(A.Length);
            Resize(A, 5);
            Console.WriteLine(A.Length); // the output is still 3! Why? 
            //to resize properly, need to pass by reference
            ResizeByRef(ref A, 5);
            Console.WriteLine(A.Length);
        }
        // pass by value: the reference held in A is copied over to x.
        // x contains the same reference to the same array referenced by A.
        // hence, any changes made even in pass by number changes the same array
        static void Increment (int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] + 1;
            }
        }
        //when we pass array A by value, the reference contained in A is copied to X. X refer to same array as A.
        static void Resize (int[] x, int newSize)
        {
            x = new int[newSize];
            // x now refer to a new instance of an array that has size newSize.
            //x now no longer refer to same array as A.
        }
        //we pass A by reference to argument x. argument A and X refer to same value (X and A are the same variable)
        static void ResizeByRef(ref int[] x, int newSize)
        {
            x = new int[newSize];
            // x now refer to a new instance of an array that has size newSize.
            //x now no longer refer to same array as A.
        }
    }
}
