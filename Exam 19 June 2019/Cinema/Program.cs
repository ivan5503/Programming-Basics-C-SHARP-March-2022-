using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string input = "";
            int incomingPeople = 0;
            int sumTicketsBought = 0;
            int finalSum = 0;
            while ((input = Console.ReadLine()) != "Movie time!")
            {


                incomingPeople = int.Parse(input);
                capacity -= incomingPeople;
                if (capacity < 0)
                {

                    Console.WriteLine($"The cinema is full.");
                    break;
                }

                sumTicketsBought = incomingPeople * 5;
                if (incomingPeople % 3 == 0)
                {
                    sumTicketsBought = sumTicketsBought - 5;
                }
                finalSum += sumTicketsBought;

            }
            if (input == "Movie time!")
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema.");

            }
            Console.WriteLine($"Cinema income - {finalSum} lv.");
        }
    }
}
