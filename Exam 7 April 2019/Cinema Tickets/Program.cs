using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int studentTSum = 0;
            int standardTSum = 0;
            int kidTSum = 0;
            int totalTicketsCounter = 0;
            while (filmName != "Finish")
            {

                int freeSeats = int.Parse(Console.ReadLine());

                string ticketType = Console.ReadLine();
                int studentTicCount = 0;
                int standardTicCount = 0;
                int kidTicCount = 0;
                int freeSeatsCounter = 0;
                while (ticketType != "End")
                {
                    freeSeatsCounter++;
                    totalTicketsCounter++;

                    if (ticketType == "student")
                    {
                        studentTicCount++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicCount++;
                    }
                    else
                    {
                        kidTicCount++;
                    }
                    if (freeSeatsCounter == freeSeats)
                    {
                        break;
                    }


                    ticketType = Console.ReadLine();

                }
                studentTSum += studentTicCount;
                standardTSum += standardTicCount;
                kidTSum += kidTicCount;
                Console.WriteLine($"{filmName} - {(studentTicCount + standardTicCount + kidTicCount) * 100.0 / freeSeats:f2}% full.");
                filmName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTicketsCounter}");
            Console.WriteLine($"{studentTSum * 100.0 / totalTicketsCounter:f2}% student tickets.");
            Console.WriteLine($"{standardTSum * 100.0 / totalTicketsCounter:f2}% standard tickets.");
            Console.WriteLine($"{kidTSum * 100.0 / totalTicketsCounter:f2}% kids tickets.");
        }
    }
}
