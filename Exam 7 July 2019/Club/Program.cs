using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int numberOfCocktails = 0;
            int cocktailPrice = 0;
            int length = 0;
            double sumOrder = 0;
            double incomings = 0;

            while (name != "Party!")
            {

                numberOfCocktails = int.Parse(Console.ReadLine());
                length = name.Length;
                cocktailPrice = length;
                sumOrder = numberOfCocktails * cocktailPrice;
                if (sumOrder % 2 != 0)
                {
                    sumOrder = sumOrder - (sumOrder * 0.25);
                }
                incomings += sumOrder;
                if (incomings >= desiredProfit)
                {
                    break;
                }

                name = Console.ReadLine();


            }
            if (incomings >= desiredProfit)
            {
                Console.WriteLine($"Target acquired.");
                Console.WriteLine($"Club income - {incomings:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {desiredProfit - incomings:f2} leva more.");
                Console.WriteLine($"Club income - {incomings:f2} leva.");
            }
        }
    }
}
