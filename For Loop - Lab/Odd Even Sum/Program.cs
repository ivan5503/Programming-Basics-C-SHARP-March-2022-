﻿using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
 
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += currentNumber;
                } 
                if (i % 2 != 0)
                {
                    evenSum += currentNumber;
                }
            }
            if (oddSum == evenSum)
            {
                 Console.WriteLine("Yes");
                 Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                 Console.WriteLine("No");
                 int diff = Math.Abs(oddSum - evenSum);
                 Console.WriteLine($"Diff = {diff}");
            
            }


            
             
        }
    }
}
