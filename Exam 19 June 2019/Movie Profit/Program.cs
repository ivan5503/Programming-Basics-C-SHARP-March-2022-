using System;

namespace Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            int daysNumber = int.Parse(Console.ReadLine());
            int ticketsNumber = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percentForKino = int.Parse(Console.ReadLine());

            double priceForDay = ticketsNumber * ticketPrice;
            double periodIncomes = priceForDay * daysNumber;
            double sumForKino = periodIncomes * percentForKino / 100;
            double netIncomes = periodIncomes - sumForKino;

            Console.WriteLine($"The profit from the movie {nameFilm} is {netIncomes:f2} lv.");
        }
    }
}
