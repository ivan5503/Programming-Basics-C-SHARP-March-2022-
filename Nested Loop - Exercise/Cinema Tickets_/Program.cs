using System;

namespace Cinema_Tickets_
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string ticketType = "";
            int totalTicket = 0;
            int studentTSum = 0;
            int standardTSum = 0;
            int kidTSum = 0;

            while (film != "Finish")
            {

                int counterOccupiedSeats = 0;
                int counterStudentTic = 0;
                int counterStandardTic = 0;
                int counterKidTic = 0;
                int freeSeats = int.Parse(Console.ReadLine());
                ticketType = Console.ReadLine();
                while (ticketType != "End")
                {
                    totalTicket++;
                    counterOccupiedSeats++;

                    if (ticketType == "student")
                    {
                        counterStudentTic++;
                    }
                    else if (ticketType == "standard")
                    {
                        counterStandardTic++;
                    }
                    else
                    {
                        counterKidTic++;
                    }
                    if (freeSeats == counterOccupiedSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();

                }
                studentTSum += counterStudentTic;
                standardTSum += counterStandardTic;
                kidTSum += counterKidTic;

                Console.WriteLine($"{film} - {(counterStudentTic + counterStandardTic + counterKidTic) * 100.0 / freeSeats:f2}% full.");
                film = Console.ReadLine();


            }
            Console.WriteLine($"Total tickets: {totalTicket}");
            Console.WriteLine($"{studentTSum * 100.0 / totalTicket:f2}% student tickets.");
            Console.WriteLine($"{standardTSum * 100.0 / totalTicket:f2}% standard tickets.");
            Console.WriteLine($"{kidTSum * 100.0 / totalTicket:f2}% kids tickets.");
        }
    }
}
