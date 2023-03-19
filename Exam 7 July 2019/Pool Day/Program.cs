using System;

namespace Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            double taxEntry = double.Parse(Console.ReadLine());
            double priceForOneSunbed = double.Parse(Console.ReadLine());
            double priceForOneUmbrella = double.Parse(Console.ReadLine());

            double sumTaxEntry = numOfPeople * taxEntry;
            double sunbets = (Math.Ceiling(0.75 * numOfPeople));
            double sumForSunbets = sunbets * priceForOneSunbed;
            double umbrellas = (Math.Ceiling(0.5 * numOfPeople));
            double sumForUmbrellas = umbrellas * priceForOneUmbrella;

            double priceAllCosts = sumTaxEntry + sumForSunbets + sumForUmbrellas;

            Console.WriteLine($"{priceAllCosts:f2} lv.");
        }
    }
}
