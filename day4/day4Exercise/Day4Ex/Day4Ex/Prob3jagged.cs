using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ex
{
    class Prob3jagged
    {
        static void Main()
        {
            int[,] studentMarks = new int[12, 4]
            {
                { 67, 55, 81, 92 },
                { 77, 58, 45, 74 },
                { 56, 65, 95, 100 },
                { 91, 75, 100, 100 },
                { 85, 87, 94, 92 },
                { 90, 91, 92, 93 },
                { 50, 50, 50, 50 },
                { 83, 60, 72, 88 },
                { 60, 60, 60, 60 },
                { 54, 75, 90, 62 },
                { 88, 82, 86, 84 },
                { 100, 100, 100, 100 }
            };
            // Each students' total marks
            for (int i = 0; i < studentMarks.GetLength(0); i++)
            {
                PrintTotal(studentMarks, i);
            }
            // Class average for each subject!!!
            for (int j = 0; j < studentMarks.GetLength(1); j++)
            {
                printSubAve(studentMarks, j);
            }
        }

        static int GetTotal(int[,] x, int studentPos)
        {
            int sum = 0;
            for (int i = 0; i < x.GetLength(1); i++)
            {
                sum = sum + x[studentPos, i];
            }
            return sum;
        }
        static void PrintTotal(int[,] x, int studentPos)
        {
            Console.WriteLine($"Student {studentPos} scored a total of {GetTotal(x, studentPos)}.");
        }
        static void printSubAve(int[,] x, int subject)
        {
            int sum = 0;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                sum = sum + x[i, subject];
            }
            double ave = (double)sum / x.GetLength(0);
            Console.WriteLine($"Total average of all students for subject {subject} is {ave:0.##}");
        }
    }
}
