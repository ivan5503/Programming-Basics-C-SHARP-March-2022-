using System;

namespace Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int seasonsNumber = int.Parse(Console.ReadLine());
            int episodNumber = int.Parse(Console.ReadLine());
            double duration1Episode = double.Parse(Console.ReadLine());

            double durationAdver1Ep = duration1Episode * 20 / 100;
            double durationWithAd = duration1Episode + durationAdver1Ep;
            int addTime = seasonsNumber * 10;

            double totalTime = seasonsNumber * episodNumber * durationWithAd + addTime;

            Console.WriteLine($"Total time needed to watch the {serialName} series is {totalTime} minutes.");
        }
    }
}
