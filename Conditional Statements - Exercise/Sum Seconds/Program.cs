using System;

namespace Sum_Seconds1
{
    class Program
    {
        static void Main(string[] args)
        {
            int racerFirstTime = int.Parse(Console.ReadLine());
            int racerSecondTime = int.Parse(Console.ReadLine());
            int racerThirdTime = int.Parse(Console.ReadLine());

            int totalRacersTime = racerFirstTime + racerSecondTime + racerThirdTime;
            int minutes = totalRacersTime / 60;
            int seconds = totalRacersTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
