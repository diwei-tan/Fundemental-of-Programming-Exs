using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        //these arrays is visible in all the static method,
        //so you can use them in your method implementation
        static int[] minIncomeArray = new int[]
        { 20000, 30000, 40000, 80000,
        120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
        { 0.02, 0.035, 0.07, 0.115,
        0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
        { 0, 200, 550, 3350,
        7950, 13950, 20750, 42350 };
        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable =
            CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }
        //YOUR CODE HERE
        static int AskForIncome()
        {
            Console.Write("Please enter your annual txable income: ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        static int GetTaxBracket (int annualincome)
        {
            for(int currentBracket = minIncomeArray.Length-1; currentBracket >= 0; currentBracket--)
            {
                if (minIncomeArray[currentBracket] < annualincome)
                {
                    //found bracket
                    return currentBracket;
                }
            }
            return -1;
        }
        static double CalculateIncomeTax (int annualIncome, int bracket)
        {
            if (bracket == -1)
            {
                return 0;
            }
            else
                return (annualIncome - minIncomeArray[bracket]) * taxRateArray[bracket] + basePayableAmountArray[bracket];
        }
        static void PrintResult(int annualIncome, double taxAmount)
        {
            Console.WriteLine($"For an annual income of {annualIncome:C}, the tax payable amount is {taxAmount:C}");
        }
    }
}
