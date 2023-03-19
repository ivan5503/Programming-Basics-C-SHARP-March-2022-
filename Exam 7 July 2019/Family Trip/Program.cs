using System;

namespace Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());
            double costOneNight = double.Parse(Console.ReadLine());
            double percentAddCosts = int.Parse(Console.ReadLine());
            double sumNights = 0;

            if (numNights > 7)
            {
                sumNights = (costOneNight - costOneNight * 0.05) * numNights;
            }
            else
            {
                sumNights = costOneNight * numNights;
            }

            double addCosts = (percentAddCosts / 100) * budget;
            double allCosts = sumNights + addCosts;
            if (budget >= allCosts)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - allCosts:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{allCosts - budget:f2} leva needed.");
            }
        }
    }
}
