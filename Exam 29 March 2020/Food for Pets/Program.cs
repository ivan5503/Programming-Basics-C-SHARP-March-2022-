using System;

namespace Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {

            int daysNumber = int.Parse(Console.ReadLine());
            double foodAllAmount = double.Parse(Console.ReadLine());
            double sumEatenDogFood = 0;
            double sumEatenCatFood = 0;
            double sumBiscuitsAmount = 0;
            double biscuitsAmount = 0;
            double eatenGeneralFood = 0;
            int counter = 3;
            for (int i = 1; i <= daysNumber; i++)
            {
                int eatenFoodDog = int.Parse(Console.ReadLine());
                sumEatenDogFood += eatenFoodDog;
                int eatenFoodCat = int.Parse(Console.ReadLine());
                sumEatenCatFood += eatenFoodCat;
                if (i == counter)
                {
                    biscuitsAmount = eatenFoodDog + eatenFoodCat;
                    biscuitsAmount = biscuitsAmount * 10 / 100.0;
                    sumBiscuitsAmount += biscuitsAmount;
                    counter += 3;
                }
            }
            eatenGeneralFood = sumEatenCatFood + sumEatenDogFood;
            double eatenFood = eatenGeneralFood * 100.0 / foodAllAmount;
            sumEatenDogFood = sumEatenDogFood * 100.0 / eatenGeneralFood;
            sumEatenCatFood = sumEatenCatFood * 100.0 / eatenGeneralFood;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(sumBiscuitsAmount)}gr.");
            Console.WriteLine($"{eatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{sumEatenDogFood:f2}% eaten from the dog.");
            Console.WriteLine($"{sumEatenCatFood:f2}% eaten from the cat.");
        }
    }
}
