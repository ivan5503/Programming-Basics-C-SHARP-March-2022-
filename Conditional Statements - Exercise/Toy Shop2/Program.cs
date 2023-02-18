using System;

namespace Toy_Shop1
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfTheTrip = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double sum = 2.60 * numberOfPuzzles + 3 * numberOfTalkingDolls + 4.10 * numberOfTeddyBears + 8.20 * numberOfMinions + 2 * numberOfTrucks;
            double numberOfToys = numberOfPuzzles + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks;
            double finalProfit = 0;
            if (numberOfToys >= 50)
            {
                double discount = sum * 0.25;
                double finalSum = sum - discount;

                double rent = finalSum * 0.1;
                finalProfit = finalSum - rent;
            }
            else if (numberOfToys < 50)
            {
                double rent = sum * 0.1;
                finalProfit = sum - rent;
            }

            if (finalProfit >= priceOfTheTrip)
            {
                Console.WriteLine($"Yes! {finalProfit - priceOfTheTrip:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceOfTheTrip - finalProfit:f2} lv needed. ");
            }
        }
    }
}
