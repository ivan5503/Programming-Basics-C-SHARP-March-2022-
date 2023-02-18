using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int heightInCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volumeOfTheAquarium = lengthInCm * widthInCm * heightInCm;
            double occupiedSpace = volumeOfTheAquarium * percent / 100;
            double freeVolumeForWater = volumeOfTheAquarium - occupiedSpace;
            double requiredLiters = freeVolumeForWater / 1000;
            Console.WriteLine(requiredLiters);
        }
    }
}
