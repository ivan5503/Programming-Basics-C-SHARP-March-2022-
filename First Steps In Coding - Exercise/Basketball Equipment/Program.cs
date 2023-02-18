using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualTrainingFee = int.Parse(Console.ReadLine());

            double priceForBasketballSneakers = annualTrainingFee - (annualTrainingFee * 40 / 100);
            double priceForBasketballOutfit = priceForBasketballSneakers - (priceForBasketballSneakers * 20 / 100);
            double priceForBasketball = priceForBasketballOutfit * 1 / 4;
            double priceForBasketballAccessories = priceForBasketball * 1 / 5;
            double totalPriceForBasketballEquipment = annualTrainingFee + priceForBasketballSneakers +
                priceForBasketballOutfit + priceForBasketball + priceForBasketballAccessories;

            Console.WriteLine($"{totalPriceForBasketballEquipment:f2}");
        }
    }
}
