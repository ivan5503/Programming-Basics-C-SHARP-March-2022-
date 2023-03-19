using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string colors = "";
            double pointsSum = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int others = 0;

            for (int i = 1; i <= number; i++)
            {
                colors = Console.ReadLine();
                if (colors == "red")
                {
                    pointsSum += 5;
                    red++;
                }
                else if (colors == "orange")
                {
                    pointsSum += 10;
                    orange++;
                }
                else if (colors == "yellow")
                {
                    pointsSum += 15;
                    yellow++;
                }
                else if (colors == "white")
                {
                    pointsSum += 20;
                    white++;
                }
                else if (colors == "black")
                {
                    pointsSum = Math.Floor(pointsSum / 2);
                    black++;

                }
                else
                {
                    others++;
                }


            }
            Console.WriteLine($"Total points: {pointsSum}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {others}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
