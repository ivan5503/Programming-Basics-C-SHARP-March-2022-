using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int flowersNum = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            if (typeFlowers == "Roses")
            {
                price = flowersNum * 5;
                if (flowersNum > 80)
                {
                    price = price - (price * 10 / 100);
                }
            }
            else if (typeFlowers == "Dahlias")
            {
                price = flowersNum * 3.80;
                if (flowersNum > 90)
                {
                    price = price - (price * 15 / 100);
                }
            }
            else if (typeFlowers == "Tulips")
            {
                price = flowersNum * 2.80;
                if (flowersNum > 80)
                {
                    price = price - (price * 15 / 100);



                }
            }
            else if (typeFlowers == "Narcissus")
            {
                price = flowersNum * 3;
                if (flowersNum < 120)
                {
                    price = price + (price * 15 / 100);
                }
            }
            else if (typeFlowers == "Gladiolus")
            {
                price = flowersNum * 2.50;
                if (flowersNum < 80)
                {
                    price = price + (price * 20 / 100);
                }
            }
            if (budget >= price)
            {

                Console.WriteLine($"Hey, you have a great garden with {flowersNum} {typeFlowers} and {budget - price:f2} leva left. ");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");

            }
        }
    }
}
