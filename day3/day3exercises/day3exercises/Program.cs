using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Day 3
            Problem 1
            int number = 0;
            while (number != 88)
            {
                Console.Write("Please input integer number: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Lucky you...");
            */

            /*
            Problem 2
            Console.WriteLine("Please input number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input number B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            int A = a;
            int B = b;
            int HCF = 0;
            while (A!=B)
            {
                if (A > B)
                    A = A - B;
                if (B > A)
                    B = B - A;
                if (A == B)
                    HCF = A;
            }
            Console.WriteLine(HCF);
            Console.WriteLine(a*b/HCF);
            */

            /*
            Problem 3
            Random rnd = new Random();
            int number = rnd.Next(0, 9);
            int guess = 0;
            int noOfGuess = 1;

            Console.Write("Please guess the number: ");
            guess = int.Parse(Console.ReadLine());
            while(guess != number)
            {
                Console.WriteLine("Try again: ");
                guess = int.Parse(Console.ReadLine());
                noOfGuess++;
            }
            if (noOfGuess < 3)
                Console.WriteLine("You are a wizard!");
            else if (noOfGuess <= 5)
                Console.WriteLine("you are a good guess");
            else
                Console.WriteLine("you are Lousy");
            */

            /*
            problem 4
            Console.Write("Please enter number: ");
            double n = double.Parse(Console.ReadLine());
            Random random = new Random();
            int guess = random.Next(0, (int)n);
            double g = Convert.ToDouble(guess);
            while (Math.Round((g * g), 5) !=  Math.Round(n, 5))
            {
                g = Math.Round((g + n / g) / 2, 5);
            }
            Console.WriteLine($"{g:0.###}");
            */

            /* Section E
            Problem 1
            Console.WriteLine("Please input integer number: ");
            int number = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int a = 1; a <= number; a++)
                fact = fact * a;
            Console.WriteLine("{0}", fact);

            int factd = 1;
            for (int b = number; b > 0; b--)
                factd = factd * b;
            Console.WriteLine("{0}", factd);
            */

            /*
            Problem 2
            Console.WriteLine(" NO\t\tINVERSE\t\tSQUARE ROOT\t\tSQUARE");
            Console.WriteLine("----------------------------------------------------------------");
            for (int a=1;a<=10;a++)
            {
                double inverse = 1.0 / a;
                double sqrt = Math.Sqrt(a);
                double sq = Math.Pow(a, 2);
                Console.WriteLine($"{a:0.0}\t\t{inverse:0.0##}\t\t{sqrt:0.0##}\t\t\t{sq:0.0}");
            }
            */

            /*
            Problem 3
            Console.Write("input number: ");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            for (int b = 1; b <= a; b++)
            {
                if (a % b == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
            */

            /*
            Problem 3
            Console.Write("input number: ");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int b = 1; b < a; b++)
            {
                if (a % b == 0)
                    sum = sum + b;
            }
            if (sum == a)
                Console.WriteLine("Perfect Number.");
            else
                Console.WriteLine("Not Perfect Number.");
            */

            /* 
            Problem 5
            for (int a = 5; a<=10000; a++)
            {
                int count = 0;
                for (int b = 1; b <= a; b++)
                {
                    if (a % b == 0)
                        count++;
                }
                if (count == 2)
                    Console.WriteLine(a);
            }
            */

            /*
            Problem 6
            for (int a = 1; a <= 1000; a++)
            {
                int sum = 0;
                for (int b = 1; b < a; b++)
                {
                    if (a % b == 0)
                        sum = sum + b;
                }
                if (sum == a)
                    Console.WriteLine(a);
            }
            */

            /* Section F
            Problem 1a
            Console.Write("Please type a phrase: ");
            string phrase = Console.ReadLine();
            phrase = phrase.ToLower();
            int count = 0;
            int len = phrase.Length;
            for(int i = 0; i < len; i++)
            {
                if (phrase.Substring(i, 1) == "a" || phrase.Substring(i, 1) == "e" ||
                    phrase.Substring(i, 1) == "i" || phrase.Substring(i, 1) == "o" ||
                    phrase.Substring(i, 1) == "u")
                    count++;
            }
            Console.WriteLine("The number of vowels is {0}.", count);
            */

            /*
            Problem 1b
            Console.Write("Please type a phrase: ");
            string phrase = Console.ReadLine();
            phrase = phrase.ToLower();
            int counta = 0;
            int counte = 0;
            int counti = 0;
            int counto = 0;
            int countu = 0;
            int len = phrase.Length;
            for (int i = 0; i < len; i++)
            {
                if (phrase.Substring(i, 1) == "a")
                    counta++;
                else if (phrase.Substring(i, 1) == "e")
                    counte++;
                else if (phrase.Substring(i, 1) == "i")
                    counti++;
                else if (phrase.Substring(i, 1) == "o")
                    counto++;
                else if (phrase.Substring(i, 1) == "u")
                    countu++;
            }
            Console.WriteLine("There are {0} a vowel, {1} e vowel, {2} i vowel," +
                " {3} o vowel, and {4} u vowel.", counta, counte, counti, counto, countu);
            */


            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();
            //input = input.ToLower();
            int len = input.Length;
            string output = "";

            for (int i = 0; i <= len - 1; i++)
            {
                output = output + input.Substring(len - 1 - i, 1); //can add many properties
            }
            if (output == input)
                Console.WriteLine("Palindrom.");
            else
                Console.WriteLine("Not Palindrom.");

        }
    }
}
