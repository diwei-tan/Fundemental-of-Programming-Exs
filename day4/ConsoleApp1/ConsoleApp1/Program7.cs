using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program7
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a);
            IncrementNumberByValue(a); //value of a is copied over as x argument. unless an output of the module corrects a, a remains the same.
            Console.WriteLine(a);
            IncrementNumberByRef(ref a);
            Console.WriteLine(a);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void IncrementNumberByValue(int x) //passing by value only
        {
            x++;
        }
        static void IncrementNumberByRef(ref int x) //passing by reference
        {
            x++;
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }

        static void IncrementNumberByOut (out int x)
        {
            // at this place, you cannot read x or use x++, as there is no instance of x as it is a output argument.
            x = 0;
            x++; //over here, you can after initialization
        }

    }
}
