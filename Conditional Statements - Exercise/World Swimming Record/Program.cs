using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

            double distanceInSeconds = distanceInMeters * timeInSecondsForOneMeter;
            double delayTime = Math.Floor(distanceInMeters / 15);
            double totalDelayTime = delayTime * 12.5;
            double totalTime = distanceInSeconds + totalDelayTime;

            if (recordInSeconds < totalTime)
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}
