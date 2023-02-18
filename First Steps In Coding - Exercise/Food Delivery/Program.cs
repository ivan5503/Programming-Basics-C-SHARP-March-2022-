using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChickenMenus = int.Parse(Console.ReadLine());
            int numberOfFischMenus = int.Parse(Console.ReadLine());
            int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

            double priceForChickenMenus = numberOfChickenMenus * 10.35;
            double priceForFischMenus = numberOfFischMenus * 12.40;
            double priceForVegetarianMenus = numberOfVegetarianMenus * 8.15;
            double totalPriceOfTheMenus = priceForChickenMenus + priceForFischMenus + priceForVegetarianMenus;
            double priceOfDessert = totalPriceOfTheMenus * 20 / 100;
            double totalPriceOfTheOrder = totalPriceOfTheMenus + priceOfDessert + 2.50;

            Console.WriteLine($"{totalPriceOfTheOrder}");
        }
    }
}
