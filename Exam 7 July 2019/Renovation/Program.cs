using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallHigh = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            int percentNoPaintArea = int.Parse(Console.ReadLine());

            string litresPaint = "";

            int totalArea = wallHigh * wallWidth * 4;
            double areaForPaint = totalArea - (totalArea * percentNoPaintArea / 100);
            while ((litresPaint = Console.ReadLine()) != "Tired!")
            {
                int painting = int.Parse(litresPaint);
                areaForPaint -= painting;
                if (areaForPaint <= 0)
                {
                    break;
                }
            }
            if (areaForPaint > 0)
            {
                Console.WriteLine($"{Math.Ceiling(areaForPaint)} quadratic m left.");

            }
            else if (areaForPaint < 0)
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(areaForPaint)} l paint left!");
            }
            else if (areaForPaint == 0)
            {
                Console.WriteLine($"All walls are painted! Great job Pesho!");
            }
        }
    }
}
