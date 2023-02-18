using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPackageOfPens = int.Parse(Console.ReadLine());
            int numberOfPackageOfMarkers = int.Parse(Console.ReadLine());
            int litersOfPreparation = int.Parse(Console.ReadLine());
            int percentageReduction = int.Parse(Console.ReadLine());

            double priceOfPackagesOfPens = numberOfPackageOfPens * 5.80;
            double priceOfPackagesOfMarkers = numberOfPackageOfMarkers * 7.20;
            double priceOfPreparation = litersOfPreparation * 1.20;
            double priceOfAllMaterials = priceOfPackagesOfPens + priceOfPackagesOfMarkers + priceOfPreparation;

            double sum = priceOfAllMaterials - (priceOfAllMaterials * percentageReduction / 100);

            Console.WriteLine($"{sum}");
        }
    }
}
