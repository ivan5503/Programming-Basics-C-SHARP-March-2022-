﻿using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0;

            if (type == "Premiere")
            {
                income = rows * colums * 12;
            }
            else if (type == "Normal")
            {
                income = rows * colums * 7.5;
            }
            else if (type == "Discount")
            {
                income = rows * colums * 5;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
