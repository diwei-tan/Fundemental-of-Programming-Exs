using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3exercises
{
    class Class2
    {
        static void Main()
        {
            /*
            Section F problem 3
            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            int len = input.Length;
            string test = "";
            string output = "";

            for (int i = 0; i < len; i++)
            {
                if (input.Substring(i, 1) != " " && input.Substring(i, 1) != "." &&
                    input.Substring(i, 1) != "," && input.Substring(i, 1) != "?" &&
                    input.Substring(i, 1) != "!")
                {
                    test = test + input.Substring(i, 1);
                }
            }

            len = test.Length; //change to length with only alphabets

            for (int j = 0; j <= len - 1; j++)
            {
                output = output + test.Substring(len - 1 - j, 1); //can add many properties
            }
            if (output == test)
                Console.WriteLine("Palindrom.");
            else
                Console.WriteLine("Not Palindrom.");
            */

            string[] students = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[5] { 63, 29, 75, 82, 55 };

            // part a: descending order of marks
            for (int i = 0; i <=4; i++)
            {
                int maxMarkPos = i;
                int maxMark = marks[i];
                // going through all, put highest mark and person in ith position (highest)
                // switch ith position with the highest mark and person for both arrays
                // first, look through to find smallest in rest of marks
                for (int j = i + 1; j <= 4; j++)
                {
                    if (marks[j] > maxMark)
                    {
                        maxMarkPos = j;
                        maxMark = marks[j];
                    }
                   
                }
                //with highest marks in bunch, shift the switch student and marks to front
                string tempStudent = students[maxMarkPos];
                int tempMark = marks[maxMarkPos];
                students[maxMarkPos] = students[i];
                marks[maxMarkPos] = marks[i];
                students[i] = tempStudent;
                marks[i] = tempMark;
            }
            Console.WriteLine("  Report 1 Sorted by descending order of marks:  ");
            Console.WriteLine("--------------------------------------------------");
            for (int k = 0; k <= 4; k++)
                Console.WriteLine("{0}\t\t{1}", students[k], marks[k]);
            Console.WriteLine("");

            //part b: names alphabetically. Note that char has value with a being smallest
            for (int x = 0; x <= 4; x++)
            {
                int minNamePos = x;
                string minName = students[x].ToLower(); //reset to next position in array

                // going through all, put earliest person and mark in ith position (earliest)
                // switch ith position with the highest mark and person for both arrays
                // first, look through to find earliest in rest of names
                for (int y = x + 1; y <= 4; y++)
                {
                    //note: first letter can be same, need to sort using subsequent letters too
                    //Compare letters from 1st letter. If different, result comes for that comparison
                    string thisName = students[y].ToLower();
                    bool resultFound = false;
                    for(int n = 0; n < 5; n++) // NOTE: if n >5, then you will get error!!! will compare 6th letter but some names only has 5 letters!!!!
                    {

                        if (thisName[n] == minName[n] && resultFound == false)
                        {
                            continue;
                        } // if first letter is same skip and go to second letter comparison
                        else if (thisName[n] < minName[n] && resultFound == false)
                        {
                            //compare from first letter if havent already
                            minNamePos = y;
                            minName = students[y].ToLower(); // ***MUST BE LOWERED TO COMPARE!!!
                            resultFound = true; // set to true so no more comparison neede after one
                        }
                        else if (thisName[n] > minName[n] && resultFound == false) //MUST TREAT AS ALREADY CHECKED!!!
                            resultFound = true;
                    }

                }
                //with earliest name in bunch, shift the switch student and marks to front
                string tempStudent = students[minNamePos];
                int tempMark = marks[minNamePos];
                students[minNamePos] = students[x];
                marks[minNamePos] = marks[x];
                students[x] = tempStudent;
                marks[x] = tempMark;
            }
            Console.WriteLine("  Report 2 Sorted by descending order of marks:  ");
            Console.WriteLine("--------------------------------------------------");
            for (int p = 0; p <= 4; p++)
                Console.WriteLine("{0}\t\t{1}", students[p], marks[p]);
        }
    }
}
