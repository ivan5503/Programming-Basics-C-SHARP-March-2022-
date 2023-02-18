using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            string input;
            double money;
            int daysCount = 0;
            int spendCount = 0;

            while (ownedMoney < neededMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                daysCount++;


                if (input == "spend")
                {
                    ownedMoney -= money;

                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                        spendCount++;
                    if (spendCount == 5)
                    {
                        break;
                    }
                }
                else
                {
                    ownedMoney += money;
                    spendCount = 0;
                }
            } 
            if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCount);
            }
        }
    }
}
