using System;

namespace Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceAbove20 = double.Parse(Console.ReadLine());
            double kilosOfLuggage = double.Parse(Console.ReadLine());
            int daysUntilTrip = int.Parse(Console.ReadLine());
            int numberOfLuggage = int.Parse(Console.ReadLine());
            double price = 0;

            if (kilosOfLuggage < 10)
            {
                price = priceAbove20 * 0.2;
                if (daysUntilTrip > 30)
                {
                    price = price + (price * 0.1);
                }
                else if (daysUntilTrip >= 7 && daysUntilTrip <= 30)
                {
                    price = price + (price * 0.15);
                }
                else if (daysUntilTrip < 7)
                {
                    price = price + (price * 0.4);
                }

            }
            else if (kilosOfLuggage >= 10 && kilosOfLuggage <= 20)
            {
                price = priceAbove20 * 0.5;
                if (daysUntilTrip > 30)
                {
                    price = price + (price * 0.1);
                }
                else if (daysUntilTrip >= 7 && daysUntilTrip <= 30)
                {
                    price = price + (price * 0.15);
                }
                else if (daysUntilTrip < 7)
                {
                    price = price + (price * 0.4);

                }
            }
            else
            {
                price = priceAbove20;
                if (daysUntilTrip > 30)
                {
                    price = price + (price * 0.1);

                }
                else if (daysUntilTrip >= 7 && daysUntilTrip <= 30)
                {
                    price = price + (price * 0.15);

                }
                else if (daysUntilTrip < 7)
                {
                    price = price + (price * 0.4);

                }
            }
            double priceForBags = price * numberOfLuggage;
            Console.WriteLine($"The total price of bags is: {priceForBags:f2} lv.");
        }
    }
}
