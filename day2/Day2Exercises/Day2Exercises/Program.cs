using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Day 2 Problem 1
            Console.Write("Please input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please input your gender (M/F): ");
            string gender = Console.ReadLine();
            if (gender == "M")
                Console.WriteLine("Good Morning Mr. {0}", name);
            else if (gender == "F")
                Console.WriteLine("Good Morning Ms. {0}", name);
            else
                Console.WriteLine("invalid input");
            */

            /* Problem 2
            Console.Write("Please input your name: ");
            string name = Console.ReadLine();
            Console.Write("Please input your gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Please input your age: ");
            int age = int.Parse(Console.ReadLine());
            if (gender == "M")
            {
                if (age >= 40)
                    Console.WriteLine("Good Morning uncle {0}", name);
                else if (age<40)
                    Console.WriteLine("Good Morning Mr. {0}", name);
            }
            else if (gender == "F")
            {
                if (age < 40)
                    Console.WriteLine("Good Morning Ms. {0}", name);
                else if (age>=40)
                    Console.WriteLine("Good Morning Aunty {}", name);
            }
            else
                Console.WriteLine("invalid input");
            */

            /*
            Problem 3
            Console.Write("Please input your marks: ");
            int mark = int.Parse(Console.ReadLine());

            if (100 >= mark && mark >= 80)
                Console.WriteLine("You scored {0} marks which is A grade", mark);
            else if (79 >= mark && mark >= 60)
                Console.WriteLine("You scored {0} marks which is B grade", mark);
            else if (59 >= mark && mark >= 40)
                Console.WriteLine("You scored {0} marks which is C grade", mark);
            else if (40 >= mark && mark >= 0)
                Console.WriteLine("You scored {0} marks which is F grade", mark);
            else
                Console.WriteLine("**Error**");
            */

            /*
            Problem 4
            Console.Write("Please input distanced travelled: ");
            double dis = double.Parse(Console.ReadLine());
            double distance = Math.Ceiling(dis*10);
            if (distance <= 50)
                Console.WriteLine(2.4);
            else if (distance <= 85)
                Console.WriteLine(2.4 + (distance-50) * 0.4);
            else
                Console.WriteLine(2.4 + 85 * 0.04 + (distance - 90) * 0.05);
            */

            Console.Write("Please input number: ");
            string number = Console.ReadLine();
            double value = NumValue(number);
            double test = Test(number);
            if (value == test)
            {
                Console.WriteLine("Armstrong Number.");
            }
            else
                Console.WriteLine("Not Armstrong Number.");

        }
        static double NumValue(string s)
        {
            double value = 0;
            for (int i=0; i<s.Length; i++)
            {
                value = value + int.Parse(s.Substring(i, 1))*Math.Pow(10, s.Length-i-1);
            }
            return value;
        }
        static double Test(string s)
        {
            double test = 0;
            for (int i = 0; i < s.Length; i++)
            {
                test = test + Math.Pow(int.Parse(s.Substring(i,1)), s.Length);
            }
            return test;
        }
    }
}
