using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Multidimensionarray
    {
        static void Main()
        {
            int[,] Marks = new int[3, 2];
            Marks[0, 0] = 35; Marks[0, 1] = 82;
            Marks[1, 0] = 67; Marks[1, 1] = 45;
            Marks[2, 0] = 62; Marks[2, 1] = 77;

            int[,] Marks2 = new int[,] //same as Marks
            {
                {35,83 },
                {67,45 },
                {62,77 }
            };
            Print2DArray(Marks);
            Print2DArray(Marks2);
        }

        public static void Print2DArray(int[,] array)
        {
            //for each rows do:
            //  for each columns, do:
            //      print the value
            //      print new line
            for (int row=0;row<array.GetLength(0); row++)
            {
                for (int col=0; col<array.GetLength(1); col++)
                {
                    Console.Write(array[row, col]);
                    if (col < array.GetLength(1) - 1)
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
