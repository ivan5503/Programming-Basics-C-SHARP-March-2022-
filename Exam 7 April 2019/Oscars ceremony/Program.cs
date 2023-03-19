using System;

namespace Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double priceFigurines = rent - rent * 0.3;
            double priceForCat = priceFigurines - priceFigurines * 0.15;
            double priceForMusic = priceForCat / 2;

            double totalPrice = rent + priceFigurines + priceForCat + priceForMusic;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
