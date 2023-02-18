using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsNumber = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int pointsW = 0;
            int pointsF = 0;
            int pointsSF = 0;
            int counterWTournaments = 0;

            for (int i = 1; i <= tournamentsNumber; i++)
            {
                string stageOfTournament = Console.ReadLine();
                if (stageOfTournament == "W")
                {
                    counterWTournaments++;
                    pointsW += 2000;
                }
                else if (stageOfTournament == "F")
                {
                    pointsF += 1200;
                }
                else if (stageOfTournament == "SF")
                {
                    pointsSF += 720;
                }
            }
            double percentWTournaments = counterWTournaments * 100.0 / tournamentsNumber;
            double averagePoints = (pointsW + pointsF + pointsSF) / tournamentsNumber;
            Console.WriteLine($"Final points: {pointsW + pointsF + pointsSF + startingPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentWTournaments:f2}%");
        }
    }
}
