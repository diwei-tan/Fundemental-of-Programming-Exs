using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class HProb3
    {
       static void Main()
        {
            bool inString = false;
            Console.Write("Please enter String 1: ");
            string s1 = Console.ReadLine().ToLower();
            Console.Write("Please enter String 2: ");
            string s2 = Console.ReadLine().ToLower();
            inString = InString(s1, s2);
            if (inString)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
        static bool InString(string a, string b)
        {
            bool found = false;
            int bLength = b.Length;
            for (int i=0; i + bLength <= a.Length; i++)
            {
                if (a.Substring(i, bLength) == b)
                    found = true;
            }
            return found;
        }
    }
}
