using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class HProb4
    {
        static void Main()
        {
            Console.Write("Please enter String 1: ");
            string s1 = Console.ReadLine().ToLower();
            Console.Write("Please enter String 2: ");
            string s2 = Console.ReadLine().ToLower();
            int startPos = FindWord(s1, s2);
            Console.WriteLine(startPos);
        }
        static int FindWord(string a, string b)
        {
            bool found = false;
            int pos = 0;
            int bLength = b.Length;
            for (int i = 0; i + bLength <= a.Length; i++)
            {
                if (a.Substring(i, bLength) == b)
                {
                    found = true;
                    pos = i;
                    break; //exit loop, gives earliest found position of substring
                }
            }
            if (found)
                return pos;
            else
                return -1;
        }
    }
}
