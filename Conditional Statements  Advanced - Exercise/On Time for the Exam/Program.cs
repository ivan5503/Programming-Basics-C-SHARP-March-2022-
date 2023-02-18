using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arraivalHour = int.Parse(Console.ReadLine());
            int arraivalMinutes = int.Parse(Console.ReadLine());

            int hours = 0;
            int minutes = 0;

            int examTimeAsMinutes = examHour * 60 + examMinutes;  // 9:30 - 570
            int arraivalTimeAsMinutes = arraivalHour * 60 + arraivalMinutes;  // 9:40 - 580
            int diffrenceExamArraival = examTimeAsMinutes - arraivalTimeAsMinutes;

            if (diffrenceExamArraival == 0)
            {
                Console.WriteLine($"On time");
            }
            else if (diffrenceExamArraival > 0 && diffrenceExamArraival <= 30)
            {
                Console.WriteLine($"On time");
                Console.WriteLine($"{diffrenceExamArraival} minutes before the start");
            }
            else if (diffrenceExamArraival < 0 && diffrenceExamArraival >= -59)
            {
                Console.WriteLine($"Late");
                Console.WriteLine($"{Math.Abs(diffrenceExamArraival)} minutes after the start");
            }
            else if (diffrenceExamArraival < -59)
            {
                hours = Math.Abs(diffrenceExamArraival / 60);
                minutes = Math.Abs(diffrenceExamArraival % 60);
                Console.WriteLine($"Late");
                Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
            }
            else if (diffrenceExamArraival > 30 && diffrenceExamArraival <= 59)
            {
                Console.WriteLine($"Early");
                Console.WriteLine($"{diffrenceExamArraival} minutes before the start");
            }
            else if (diffrenceExamArraival > 59)
            {
                hours = diffrenceExamArraival / 60;
                minutes = diffrenceExamArraival % 60;
                Console.WriteLine($"Early");
                Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
            }
        }
    }
}
