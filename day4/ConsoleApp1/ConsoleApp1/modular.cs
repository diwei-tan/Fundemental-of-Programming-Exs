using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class modular
    {
       

        //This method would print te prompt to the use and get user input and return an integer.

        public static int ReadInteger(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int number;
            while (int.TryParse(input, out number)==false)
            {
                Console.WriteLine("Invalid input, please try again: ");
                Console.Write(prompt);
                input = Console.ReadLine();
            }
            return number;
        }
    }
}
