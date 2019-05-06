using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class HProb9
    {
        static void Main()
        {
            for (int i = 5; i <= 1000; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine(i);
            }
        }
        static bool IsPrime(int x)
        {
                int primeCheck = 0;
                for (int j=2; j<=x; j++)
                {
                    if (x % j == 0)
                        primeCheck++;
                }
                if (primeCheck == 1)
                    return true;
                else
                    return false;
        }
    }
}
