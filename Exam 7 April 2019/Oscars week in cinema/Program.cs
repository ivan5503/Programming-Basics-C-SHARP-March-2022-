using System;

namespace Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            string typeHall = Console.ReadLine();
            int ticketBought = int.Parse(Console.ReadLine());
            double incomings = 0;

            if (nameFilm == "A Star Is Born")
            {
                if (typeHall == "normal")
                {
                    incomings = ticketBought * 7.50;
                }
                else if (typeHall == "luxury")
                {
                    incomings = ticketBought * 10.50;
                }
                else
                {
                    incomings = ticketBought * 13.50;
                }
            }
            else if (nameFilm == "Bohemian Rhapsody")
            {
                if (typeHall == "normal")
                {
                    incomings = ticketBought * 7.35;
                }
                else if (typeHall == "luxury")
                {
                    incomings = ticketBought * 9.45;
                }
                else
                {
                    incomings = ticketBought * 12.75;
                }
            }
            else if (nameFilm == "Green Book")
            {
                if (typeHall == "normal")
                {
                    incomings = ticketBought * 8.15;
                }
                else if (typeHall == "luxury")
                {
                    incomings = ticketBought * 10.25;
                }
                else
                {
                    incomings = ticketBought * 13.25;
                }
            }
            else
            {
                if (typeHall == "normal")
                {
                    incomings = ticketBought * 8.75;
                }
                else if (typeHall == "luxury")
                {
                    incomings = ticketBought * 11.55;
                }
                else
                {
                    incomings = ticketBought * 13.95;
                }
            }
            Console.WriteLine($"{nameFilm} -> {incomings:f2} lv.");
        }
    }
}
