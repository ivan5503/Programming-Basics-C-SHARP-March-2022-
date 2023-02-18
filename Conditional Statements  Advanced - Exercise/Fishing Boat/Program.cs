using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishMan = int.Parse(Console.ReadLine());
            double rentPrice = 0;
            if (season == "Spring")
            {
                rentPrice = 3000;
                if (fishMan <= 6)
                {
                    rentPrice = rentPrice - (rentPrice * 10 / 100);
                }
                else if (fishMan >= 7 && fishMan <= 11)
                {
                    rentPrice = rentPrice - (rentPrice * 15 / 100);
                }
                else if (fishMan >= 12)
                {
                    rentPrice = rentPrice - (rentPrice * 25 / 100);
                }
                if (fishMan % 2 == 0)
                {
                    rentPrice = rentPrice - (rentPrice * 5 / 100);
                }
            }
            else if (season == "Summer")
            {
                rentPrice = 4200;
                if (fishMan <= 6)
                {
                    rentPrice = rentPrice - (rentPrice * 10 / 100);
                }
                else if (fishMan >= 7 && fishMan <= 11)
                {
                    rentPrice = rentPrice - (rentPrice * 15 / 100);
                }
                else if (fishMan >= 12)
                {
                    rentPrice = rentPrice - (rentPrice * 25 / 100);
                }
                if (fishMan % 2 == 0)
                {
                    rentPrice = rentPrice - (rentPrice * 5 / 100);
                }

            }
            else if (season == "Autumn")
            {
                rentPrice = 4200;
                if (fishMan <= 6)
                {
                    rentPrice = rentPrice - (rentPrice * 10 / 100);
                }
                else if (fishMan >= 7 && fishMan <= 11)
                {
                    rentPrice = rentPrice - (rentPrice * 15 / 100);
                }
                else if (fishMan >= 12)
                {
                    rentPrice = rentPrice - (rentPrice * 25 / 100);
                }

            }
            else if (season == "Winter")
            {
                rentPrice = 2600;
                if (fishMan <= 6)
                {
                    rentPrice = rentPrice - (rentPrice * 10 / 100);
                }
                else if (fishMan >= 7 && fishMan <= 11)
                {
                    rentPrice = rentPrice - (rentPrice * 15 / 100);
                }
                else if (fishMan >= 12)
                {
                    rentPrice = rentPrice - (rentPrice * 25 / 100);
                }
                if (fishMan % 2 == 0)
                {
                    rentPrice = rentPrice - (rentPrice * 5 / 100);
                }

            }
            if (groupBudget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {groupBudget - rentPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rentPrice - groupBudget:f2} leva.");
            }

        }
    }
}
