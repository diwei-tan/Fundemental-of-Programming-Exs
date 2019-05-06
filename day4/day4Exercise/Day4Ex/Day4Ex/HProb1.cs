using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class HProb1
    {
        static void Main()
        {
            int input = ReadInteger("Please enter integer number: ");
            Console.WriteLine(input);
        }
        static int ReadInteger(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int number;
            while (int.TryParse(input, out number) == false)
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.Write(prompt);
                input = Console.ReadLine();
            }
            return number;
        }
    }
}
