using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class HProb5
    {
        static void Main()
        {
            int input = 0;
            Console.Write("Please input integer: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", ConvertToHex(input));
        }
        static string ConvertToHex(int x)
        {
            string hexa = x.ToString("X");
            return hexa;
        }
    }
}
