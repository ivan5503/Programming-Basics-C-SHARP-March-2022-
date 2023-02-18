using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsNum = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartamentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartamentPrice = 65;
                studioPrice = studioPrice * nightsNum;
                apartamentPrice = apartamentPrice * nightsNum;
                if (nightsNum > 14)
                {
                    studioPrice = studioPrice - (studioPrice * 30 / 100);
                    apartamentPrice = apartamentPrice - (apartamentPrice * 10 / 100);
                }
                else if (nightsNum > 7)
                {
                    studioPrice = studioPrice - (studioPrice * 5 / 100);
                }

            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartamentPrice = 68.70;
                studioPrice = studioPrice * nightsNum;
                apartamentPrice = apartamentPrice * nightsNum;
                if (nightsNum > 14)
                {
                    studioPrice = studioPrice - (studioPrice * 20 / 100);
                    apartamentPrice = apartamentPrice - (apartamentPrice * 10 / 100);

                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartamentPrice = 77;
                studioPrice = studioPrice * nightsNum;
                apartamentPrice = apartamentPrice * nightsNum;
                if (nightsNum > 14)
                {

                    apartamentPrice = apartamentPrice - (apartamentPrice * 10 / 100);
                }
            }
            Console.WriteLine($"Apartment: {apartamentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
