﻿using System;

namespace Coins_
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine()) * 100;
            int resto = (int)input;
            int coinsCounter = 0;

            while (resto > 0.00)
            {
                if (resto >= 200)
                {
                    resto -= 200;
                }
                else if (resto >= 100)
                {
                    resto -= 100;
                }
                else if (resto >= 50)
                {
                    resto -= 50;
                }
                else if (resto >= 20)
                {
                    resto -= 20;
                }
                else if (resto >= 10)
                {
                    resto -= 10;
                }
                else if (resto >= 5)
                {
                    resto -= 5;
                }
                else if (resto >= 2)
                {
                    resto -= 2;
                }
                else if (resto >= 0.01)
                {
                    resto -= 1;
                }
                coinsCounter++;
            }
            Console.WriteLine($"{coinsCounter}");
        }
    }
}
