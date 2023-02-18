using System;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            int totalReadingTime = numberOfPages / pagesPerHour;
            int requiredHoursPerDay = totalReadingTime / numberOfDays;
            Console.WriteLine(requiredHoursPerDay);
        }
    }
}
