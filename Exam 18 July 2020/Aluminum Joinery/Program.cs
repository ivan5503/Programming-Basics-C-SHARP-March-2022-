using System;

namespace Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int frameNum = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string deliveringWay = Console.ReadLine();
            double price = 0;
            if (frameNum < 10)
            {
                Console.WriteLine($"Invalid order");
                return;
            }
            if (type == "90X130")
            {
                if (frameNum > 30 && frameNum <= 60)
                {
                    price = frameNum * 110;
                    price = price - (price * 5 / 100);
                }
                else if (frameNum > 60)
                {
                    price = frameNum - 110;
                    price = price - (price * 8 / 100);
                }
                if (deliveringWay == "With delivery")
                {
                    price += 60;
                }


            }
            else if (type == "100X150")
            {
                if (frameNum > 40 && frameNum <= 80)
                {
                    price = frameNum * 140;
                    price = price - (price * 6 / 100);
                }
                else if (frameNum > 80)
                {
                    price = frameNum * 140;
                    price = price - (price * 10 / 100);
                }
                if (deliveringWay == "With delivery")
                {
                    price += 60;
                }
            }
            else if (type == "130X180")
            {
                if (frameNum > 20 && frameNum <= 50)
                {
                    price = frameNum * 190;
                    price = price - (price * 7 / 100);
                }
                else if (frameNum > 50)
                {
                    price = frameNum * 190;
                    price = price - (price * 12 / 100);
                }
                if (deliveringWay == "With delivery")
                {
                    price += 60;
                }
            }
            else if (type == "200X300")
            {
                if (frameNum > 25 && frameNum <= 50)
                {
                    price = frameNum * 250;
                    price = price - (price * 9 / 100);

                }
                else if (frameNum > 50)
                {
                    price = frameNum * 250;
                    price = price - (price * 14 / 100);
                }
                if (deliveringWay == "With delivery")
                {
                    price += 60;
                }
            }
            if (frameNum > 99)
            {
                price = price - (price * 4 / 100);
            }

            Console.WriteLine($"{price:f2} BGN");
        }
    }
}
