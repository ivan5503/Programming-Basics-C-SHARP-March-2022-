using System;

namespace Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int adultNum = int.Parse(Console.ReadLine());
            int kidNum = int.Parse(Console.ReadLine());
            double nettoPrice = double.Parse(Console.ReadLine());
            double serviceTax = double.Parse(Console.ReadLine());

            double priceAdultTic = nettoPrice + serviceTax;
            double discountKidTic = nettoPrice - nettoPrice * 0.7;
            double finalPriceKidTic = discountKidTic + serviceTax;
            double soldAdultTic = adultNum * priceAdultTic;
            double soldKidTic = finalPriceKidTic * kidNum;
            double profit = soldAdultTic + soldKidTic;
            double agencyProfit = profit * 0.2;

            Console.WriteLine($"The profit of your agency from {name} tickets is {agencyProfit:f2} lv.");
        }
    }
}
