using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();

            double area = 0;
            if (typeOfFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (typeOfFigure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (typeOfFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
            }
            else if (typeOfFigure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double heightA = double.Parse(Console.ReadLine());
                area = sideA * heightA / 2;
            }
            if (area != 0)
            {
                Console.WriteLine($"{area:f3}");
            }
            else
            {
                Console.WriteLine("Area is zero,or invalid figure type");
            }
        }
    }
}
