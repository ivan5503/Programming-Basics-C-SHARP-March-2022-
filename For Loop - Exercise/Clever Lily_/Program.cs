using System;

namespace Clever_Lily_
{
    class Program
    {
        static void Main(string[] args)
        {
            int liliAge = int.Parse(Console.ReadLine());
            double washingMPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toysSum = 0;
            int money = 0;
            int moneyCounter = 0;
            int sumMoney = 0;

            for (int i = 1; i <= liliAge; i++)
            {
                if (i % 2 != 0)
                {
                    toysSum += toyPrice;
                }
                else if (i % 2 == 0)
                {
                    moneyCounter++;
                    money = moneyCounter * 10;
                    money -= 1;
                    sumMoney += money;
                }

            }
            sumMoney = sumMoney + toysSum;
            if (sumMoney >= washingMPrice)
            {
                Console.WriteLine($"Yes! {sumMoney - washingMPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMPrice - sumMoney:f2}");
            }
        }
    }
}
