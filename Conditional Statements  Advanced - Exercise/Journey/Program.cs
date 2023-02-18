using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    budget = budget * 30 / 100;
                }
                else if (season == "winter")
                {
                    budget = budget * 70 / 100;
                }
                Console.WriteLine($"Somewhere in {"Bulgaria"}");
                if (season == "summer")
                {
                    Console.WriteLine($"{"Camp"} - {budget:f2}");
                }
                else
                {
                    Console.WriteLine($"{"Hotel"} - {budget:f2}");
                }

            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    budget = budget * 40 / 100;
                }
                else if (season == "winter")
                {
                    budget = budget * 80 / 100;
                }
                Console.WriteLine($"Somewhere in {"Balkans"}");
                if (season == "summer")
                {
                    Console.WriteLine($"{"Camp"} - {budget:f2}");
                }
                else
                {
                    Console.WriteLine($"{"Hotel"} - {budget:f2}");
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer")
                {
                    budget = budget * 90 / 100;
                }
                else if (season == "winter")
                {
                    budget = budget * 90 / 100;
                }
                Console.WriteLine($"Somewhere in {"Europe"}");
                Console.WriteLine($"{"Hotel"} - {budget:f2}");

            }
        }
    }
}
