using System;

namespace Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int walkingInMin = int.Parse(Console.ReadLine());
            int walkingsNum = int.Parse(Console.ReadLine());
            int calorisPerDay = int.Parse(Console.ReadLine());

            int walkingsInMinPerDay = walkingInMin * walkingsNum;
            int burnedCalories = walkingsInMinPerDay * 5;

            if (burnedCalories >= calorisPerDay / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
