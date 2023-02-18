using System;

namespace Shopping2
{
    class Program
    {
        static void Main(string[] args)
        {
            double petersBudget = double.Parse(Console.ReadLine());
            int numberOfVideocards = int.Parse(Console.ReadLine());
            int numberOfProcessors = int.Parse(Console.ReadLine());
            int numberOfRamMemory = int.Parse(Console.ReadLine());

            int sumForVideocards = numberOfVideocards * 250;
            double priceForOneProcessor = sumForVideocards * 0.35;
            double sumForProcessors = priceForOneProcessor * numberOfProcessors;
            double sumForRamMemory = (sumForVideocards * 0.1) * numberOfRamMemory;
            double totalSum = sumForVideocards + sumForProcessors + sumForRamMemory;

            if (numberOfVideocards > numberOfProcessors)
            {
                totalSum = totalSum * 0.85;
            }
            if (totalSum <= petersBudget)
            {
                Console.WriteLine($"You have {petersBudget - totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(petersBudget - totalSum):f2} leva more!");
            }
        }
    }
}
