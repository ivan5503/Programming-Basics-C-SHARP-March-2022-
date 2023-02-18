using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double accruedInterest = depositedAmount * annualInterestRate / 100;
            double interestPerMonth = accruedInterest / 12;
            double amount = depositedAmount + (termOfDeposit * interestPerMonth);
            Console.WriteLine($"{amount:f2}");
        }
    }
}
