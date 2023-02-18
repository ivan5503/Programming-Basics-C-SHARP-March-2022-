using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = minutes + (hours * 60);
            int timeAfter15Min = timeInMinutes + 15;

            int hoursAfter15Min = timeAfter15Min / 60;
            int minutesAfter15Min = timeAfter15Min % 60;

            if (hoursAfter15Min > 23)
            {
                hoursAfter15Min = hoursAfter15Min - 24;
            }
            else if (minutesAfter15Min < 10)
            {
                Console.WriteLine($"{hoursAfter15Min}:0{minutesAfter15Min}");
            }
            else
            {
                Console.WriteLine($"{hoursAfter15Min}:{minutesAfter15Min}");
            }
               
        }
    }
}
