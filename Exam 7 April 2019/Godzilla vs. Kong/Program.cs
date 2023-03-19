using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extra = int.Parse(Console.ReadLine());
            double priceClothesExtra = double.Parse(Console.ReadLine());
            double sumForDekor = budget * 10 / 100;
            double sumForClothes = 0;
            if (extra > 150)
            {
                sumForClothes = extra * priceClothesExtra;
                sumForClothes = sumForClothes - sumForClothes * 10 / 100;
            }
            else
            {
                sumForClothes = extra * priceClothesExtra;
            }

            double totalPriceFilm = sumForDekor + sumForClothes;

            if (totalPriceFilm > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {totalPriceFilm - budget:f2} leva more.");
            }
            else if (totalPriceFilm <= budget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPriceFilm:f2} leva left.");
            }
        }
    }
}
