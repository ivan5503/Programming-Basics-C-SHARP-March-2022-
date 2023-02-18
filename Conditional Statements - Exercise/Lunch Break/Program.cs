using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string theSopranos = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int durationOfTheRest = int.Parse(Console.ReadLine());

            double timeForLunch = durationOfTheRest * 0.125;
            double leisureTime = durationOfTheRest * 0.25;
            double restTime = durationOfTheRest - (timeForLunch + leisureTime);

            if (restTime >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {theSopranos} and left with {Math.Ceiling(restTime - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {theSopranos}, you need {Math.Ceiling(episodeDuration - restTime)} more minutes.");
            }
        }
    }
}
