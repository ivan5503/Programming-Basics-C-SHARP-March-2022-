using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNylon = int.Parse(Console.ReadLine());
            int amountOfPaint = int.Parse(Console.ReadLine());
            int amountOfDiluent = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double sumForNylon = ((amountOfNylon + 2) * 1.5);
            double sumForPaint = (14.50 * amountOfPaint) + (14.50 * amountOfPaint * 0.1);
            double sumForDiluent = amountOfDiluent * 5;
            double sumForMaterials = sumForNylon + sumForPaint + sumForDiluent + 0.4;
            double sumForMasters = sumForMaterials * 0.3 * workingHours;
            double finalSum = sumForMasters + sumForMaterials;

            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
