using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array
    {
        static void Main()
        {
            int[] array = new int[] { 3, 2, 1, 4, 0, 5 };

            for(int green=0; green < array.Length; green++)
            {
                for(int red=green+1; red < array.Length; red++)
                {
                    if (array[red] < array[green])
                    {
                        //swap
                        int temp = array[red];
                        array[red] = array[green];
                        array[green] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}");
        }
    }
}
