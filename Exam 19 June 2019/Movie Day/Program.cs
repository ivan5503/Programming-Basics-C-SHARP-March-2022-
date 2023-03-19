using System;

namespace Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int shootTime = int.Parse(Console.ReadLine());
            int sceneNumber = int.Parse(Console.ReadLine());
            int durationScene = int.Parse(Console.ReadLine());

            int fieldPreparation = shootTime * 15 / 100;
            int timeForScenes = sceneNumber * durationScene;
            int neededTime = timeForScenes + fieldPreparation;

            if (shootTime > neededTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {shootTime - neededTime} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {neededTime - shootTime} minutes.");

            }
        }
    }
}
