﻿using System;

namespace Half_Sum_Element_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNumber = int.MinValue;
            int number = 0;

            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());

                sum = sum + number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

            }
            sum = sum - maxNumber;
            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sum)}");
            }

        }
    }
}
