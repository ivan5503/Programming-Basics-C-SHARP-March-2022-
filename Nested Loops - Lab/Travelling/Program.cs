using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double savedMoney = 0;
            double minimalBudget = 0;
            while (true)
            {
                string destination = Console.ReadLine();
                if(destination == "End")
                {
                    break;
                }
                minimalBudget = int.Parse(Console.ReadLine());
                savedMoney = 0;
                while (true)
                {
                    if (savedMoney >= minimalBudget)
                    {
                        break;
                    }
                    savedMoney += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");


            }
        }
    }
}
