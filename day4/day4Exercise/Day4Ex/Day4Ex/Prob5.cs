using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class Prob5
    {
        static void Main()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int numPos = 0;
            for(int i=0; i<=A.Length; i++)
            {
                if (A[i] == number)
                {
                    numPos = i;
                    break;
                }
                else if (numPos == 0 && i == A.Length)
                    numPos = -1;
            }
            Console.WriteLine("Number {0} is found in the array at the element no. {1}", number, numPos+1);
        } 
    }
}
