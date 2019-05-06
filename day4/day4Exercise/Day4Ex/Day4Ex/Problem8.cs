using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class Problem8
    {
        static void Main()
        {
            int[,] A = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            bool found = false;
            for (int i=0; i<A.GetLength(0); i++)
            {
                for(int j=0; j < A.GetLength(1); j++)
                {
                    if(A[i, j] == number)
                    {
                        x = i;
                        y = j;
                        found = true;
                    }
                }
            }
            if (found)
                Console.WriteLine($"Number {number} is found in the array [{x},{y}].");
            else
                Console.WriteLine("Number is not found.");
        }
    }
}
