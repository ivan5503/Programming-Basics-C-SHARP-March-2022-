using System;

namespace Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string filmPacket = Console.ReadLine();
            int ticketsNumber = int.Parse(Console.ReadLine());
            double finalBill = 0;
            if (filmName == "John Wick")
            {
                if (filmPacket == "Drink")
                {
                    finalBill = 12 * ticketsNumber;
                }
                else if (filmPacket == "Popcorn")
                {
                    finalBill = 15 * ticketsNumber;
                }
                else
                {
                    finalBill = 19 * ticketsNumber;
                }

            }
            else if (filmName == "Star Wars")
            {
                if (filmPacket == "Drink")
                {
                    finalBill = 18 * ticketsNumber;
                    if (ticketsNumber >= 4)
                    {
                        finalBill = finalBill - (finalBill * 0.3);
                    }

                }
                else if (filmPacket == "Popcorn")
                {
                    finalBill = 25 * ticketsNumber;
                    if (ticketsNumber >= 4)
                    {
                        finalBill = finalBill - (finalBill * 0.3);
                    }
                }
                else
                {
                    finalBill = 30 * ticketsNumber;
                    if (ticketsNumber >= 4)
                    {
                        finalBill = finalBill - (finalBill * 0.3);
                    }
                }


            }
            else
            {
                if (filmPacket == "Drink")
                {
                    finalBill = 9 * ticketsNumber;
                    if (ticketsNumber == 2)
                    {
                        finalBill = finalBill - (finalBill * 0.15);
                    }
                }
                else if (filmPacket == "Popcorn")
                {
                    finalBill = 11 * ticketsNumber;
                    if (ticketsNumber == 2)
                    {
                        finalBill = finalBill - (finalBill * 0.15);
                    }
                }
                else
                {
                    finalBill = 14 * ticketsNumber;
                    if (ticketsNumber == 2)
                    {
                        finalBill = finalBill - (finalBill * 0.15);
                    }
                }
            }
            Console.WriteLine($"Your bill is {finalBill:f2} leva.");
        }
    }
}
