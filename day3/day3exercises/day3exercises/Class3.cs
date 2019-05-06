using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3exercises
{
    class Class3
    {
        static void Main()
        {
            bool valid = false;
            Console.Write("Please enter a matriculation number: ");
            string matric = Console.ReadLine();
            
            int len = matric.Length;
            if (len != 7)
                Console.WriteLine("Matriculation number is invalid.");
            else
            {
                matric = matric.ToUpper();
                int numbers = int.Parse(matric.Substring(1, 5));
                int verify = 0;
                int forDigitFinding = numbers;
                //handle first digit
                verify = verify + (forDigitFinding % 10) * 2;
                for (int i = 1; i <= 4; i++)
                {
                    forDigitFinding = forDigitFinding / 10;
                    verify = verify + forDigitFinding % 10 * (i + 2);
                }
                verify = verify % 5;

                switch (verify)
                {
                    case 0:
                        if (matric.Substring(6, 1) == "O")
                            valid = true;
                        break;
                    case 1:
                        if (matric.Substring(6, 1) == "P")
                            valid = true;
                        break;
                    case 2:
                        if (matric.Substring(6, 1) == "Q")
                            valid = true;
                        break;
                    case 3:
                        if (matric.Substring(6, 1) == "R")
                            valid = true;
                        break;
                    case 4:
                        if (matric.Substring(6, 1) == "S")
                            valid = true;
                        break;
                }
                if (valid == true)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
        }
    }
}
