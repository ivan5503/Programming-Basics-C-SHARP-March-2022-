using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int serialNumber = int.Parse(Console.ReadLine());
            string nameSerial = "";
            double serialPrice = 0;
            double sumSerials = 0;

            for (int i = 1; i <= serialNumber; i++)
            {
                nameSerial = Console.ReadLine();
                serialPrice = double.Parse(Console.ReadLine());

                if (nameSerial == "Thrones")
                {
                    serialPrice = serialPrice - (serialPrice * 0.5);
                    sumSerials += serialPrice;
                }
                else if (nameSerial == "Lucifer")
                {
                    serialPrice = serialPrice - (serialPrice * 0.4);
                    sumSerials += serialPrice;
                }
                else if (nameSerial == "Protector")
                {
                    serialPrice = serialPrice - (serialPrice * 0.3);
                    sumSerials += serialPrice;
                }
                else if (nameSerial == "TotalDrama")
                {
                    serialPrice = serialPrice - (serialPrice * 0.2);
                    sumSerials += serialPrice;
                }
                else if (nameSerial == "Area")
                {
                    serialPrice = serialPrice - (serialPrice * 0.1);
                    sumSerials += serialPrice;
                }
                else
                {
                    sumSerials += serialPrice;
                }

            }
            if (budget >= sumSerials)
            {
                Console.WriteLine($"You bought all the series and left with {budget - sumSerials:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budget - sumSerials):f2} lv. more to buy the series!");
            }
        }
    }
}
