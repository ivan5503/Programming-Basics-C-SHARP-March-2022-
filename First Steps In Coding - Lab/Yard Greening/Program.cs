using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());

            double priceForYardGreening = squareMeters * 7.61;
            double discount = priceForYardGreening * 18 / 100;
            double theFinalPrice = priceForYardGreening - discount;

            Console.WriteLine($"The final price is: {theFinalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
