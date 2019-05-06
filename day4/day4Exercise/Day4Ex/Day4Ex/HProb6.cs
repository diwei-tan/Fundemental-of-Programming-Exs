using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class HProb6
    {
        static void Main()
        {
            Console.Write("Please input string: ");
            string x = Console.ReadLine();
            Console.Write("Please input c1: ");
            char c1 = char.Parse(Console.ReadLine());
            Console.Write("Please input c2: ");
            char c2 = char.Parse(Console.ReadLine());
            Console.WriteLine(Substitute(x, c1, c2));
        }
        static string Substitute(string line, char a, char b)
        {
            StringBuilder changedSentence = new StringBuilder(line);
            changedSentence.Replace(a, b);
            return changedSentence.ToString();
        }
    }
}
