﻿using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int current = 1;
            
            for (int rows = 1; rows <= number; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(current + " ");
                    current++;
                    if (current > number)
                    {
                        break;
                    }

                }
                Console.WriteLine();
                if (current > number)
                {
                    break;
                }

            }
        }
    }
}
