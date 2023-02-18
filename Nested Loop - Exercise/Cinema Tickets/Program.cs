using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                int freeTickets = int.Parse(Console.ReadLine());

                int tickets = 0;

                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    tickets++;
                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else
                    {
                        kidTickets++;
                    }
                    if (freeTickets == tickets)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }
                double occupancy = tickets * 100.0 / freeTickets;
                Console.WriteLine($"{input} - {occupancy:f2}% full.");
                input = Console.ReadLine();
            }
            int totalTickets = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");

            Console.WriteLine($"{studentTickets * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{standardTickets * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 100.0 / totalTickets:f2}% kids tickets.");
        }
    }
}
