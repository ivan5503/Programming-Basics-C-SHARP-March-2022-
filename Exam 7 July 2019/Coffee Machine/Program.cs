using System;

namespace Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());
            double priceEspr = 0;
            double priceCapp = 0;
            double priceTea = 0;

            if (drink == "Espresso")
            {

                if (sugar == "Without")
                {
                    priceEspr = numberOfDrinks * 0.90;
                    priceEspr = priceEspr - (priceEspr * 0.35);
                    if (numberOfDrinks >= 5)
                    {
                        priceEspr = priceEspr - (priceEspr * 0.25);
                    }
                }
                else if (sugar == "Normal")
                {

                    priceEspr = numberOfDrinks * 1;
                    if (numberOfDrinks >= 5)
                    {
                        priceEspr = priceEspr - (priceEspr * 0.25);
                    }
                }
                else
                {
                    priceEspr = numberOfDrinks * 1.20;
                    if (numberOfDrinks >= 5)
                    {
                        priceEspr = priceEspr - (priceEspr * 0.25);
                    }

                }
                if (priceEspr > 15)
                {
                    priceEspr = priceEspr - (priceEspr * 0.2);
                }
                Console.WriteLine($"You bought {numberOfDrinks} cups of {drink} for {priceEspr:f2} lv.");



            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    priceCapp = numberOfDrinks * 1;
                    priceCapp = priceCapp - (priceCapp * 0.35);

                }
                else if (sugar == "Normal")
                {
                    priceCapp = numberOfDrinks * 1.20;


                }
                else
                {
                    priceCapp = numberOfDrinks * 1.60;

                }
                if (priceCapp > 15)
                {
                    priceCapp = priceCapp - (priceCapp * 0.2);
                }
                Console.WriteLine($"You bought {numberOfDrinks} cups of {drink} for {priceCapp:f2} lv.");



            }
            else
            {
                if (sugar == "Without")
                {
                    priceTea = numberOfDrinks * 0.5;
                    priceTea = priceTea - (priceTea * 0.35);

                }
                else if (sugar == "Normal")
                {
                    priceTea = numberOfDrinks * 0.60;

                }
                else
                {
                    priceTea = numberOfDrinks * 0.70;

                }
                if (priceTea > 15)
                {
                    priceTea = priceTea - (priceTea * 0.2);
                }
                Console.WriteLine($"You bought {numberOfDrinks} cups of {drink} for {priceTea:f2} lv.");


            }
        }
    }
}
