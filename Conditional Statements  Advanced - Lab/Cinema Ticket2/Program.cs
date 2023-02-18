using System;

namespace Cinema_Ticket1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();

            int price = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Friday")
            {
                price = 12;
                Console.WriteLine(price);
            }
            else if (dayOfWeek == "Wednesday" || dayOfWeek == "Thursday")
            {
                price = 14;
                Console.WriteLine(price);
            }
            else
            {
                price = 16;
                Console.WriteLine(price);
            }
        }
    }
}
