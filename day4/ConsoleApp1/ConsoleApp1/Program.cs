using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 100, 200, 300, 0, 0 };

            for (int i=0; i<A.Length; i++)
            {
                Console.WriteLine($"A[{i}] = {A[i]}");
                Console.WriteLine(i + "-" + A[i]);
            }
        }
    }
}
