using System;

namespace Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInMet = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());

            double delay = Math.Floor(distanceInMet / 50);
            double delayInSec = delay * 30;
            double timeForClimbing = distanceInMet * timeInSec;
            double totalTimeForClimbing = timeForClimbing + delayInSec;

            if (totalTimeForClimbing < recordInSec)
            {
                Console.WriteLine($"Yes! The new record is {totalTimeForClimbing:f2} seconds.");
            }
            else if (totalTimeForClimbing >= recordInSec)
            {
                Console.WriteLine($"No! He was {totalTimeForClimbing - recordInSec:f2} seconds slower.");
            }
        }
    }
}
