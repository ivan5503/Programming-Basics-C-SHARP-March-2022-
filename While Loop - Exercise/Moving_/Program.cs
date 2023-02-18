using System;

namespace Moving_
{
    class Program
    {
        static void Main(string[] args)
        {

            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());
            string boxesNumber = "";
            int occupiedCubicM = 0;
            int availableCubicM = 0;

            availableCubicM = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;
            while ((boxesNumber = Console.ReadLine()) != "Done")
            {
                occupiedCubicM += int.Parse(boxesNumber);
                if (occupiedCubicM > availableCubicM)
                {
                    Console.WriteLine($"No more free space! You need {occupiedCubicM - availableCubicM} Cubic meters more.");
                    break;
                }

            }
            if (occupiedCubicM < availableCubicM)
            {
                Console.WriteLine($"{availableCubicM - occupiedCubicM} Cubic meters left.");

            }
        }
    }
}
