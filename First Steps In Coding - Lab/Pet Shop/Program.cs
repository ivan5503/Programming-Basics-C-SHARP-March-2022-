using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogFood = int.Parse(Console.ReadLine());
            int numberOfCatFood = int.Parse(Console.ReadLine());

            double finalSum = (2.50 * numberOfDogFood) + (4 * numberOfCatFood);

            Console.WriteLine($"{finalSum} lv.");
        }
    }
}
