using System;

namespace Godzilla_vs._Kong1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetOfTheFilm = double.Parse(Console.ReadLine());
            int numberOfTripods = int.Parse(Console.ReadLine());
            double clothingPriceForOne = double.Parse(Console.ReadLine());

            double decorForFilm = budgetOfTheFilm * 0.1;
            double priceForClothing = numberOfTripods * clothingPriceForOne;


            if (numberOfTripods > 150)
            {
                priceForClothing = priceForClothing * 0.9;

            }
            double totalPriceForTheFilm = priceForClothing + decorForFilm;

            if (totalPriceForTheFilm > budgetOfTheFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budgetOfTheFilm - totalPriceForTheFilm):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budgetOfTheFilm - totalPriceForTheFilm:f2} leva left.");
            }
        }
    }
}
