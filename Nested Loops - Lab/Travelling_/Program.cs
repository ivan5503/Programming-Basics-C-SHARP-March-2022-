using System;

namespace Travelling_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            int minimalBudget = 0;

            int savedMoney = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                minimalBudget = int.Parse(Console.ReadLine());
                while (true)
                {
                    savedMoney += int.Parse(Console.ReadLine());
                    if (savedMoney >= minimalBudget)
                    {
                        Console.WriteLine($"Going to {input}!");
                        savedMoney = 0;
                        break;
                    }
                }

            }
        }
    }
}
