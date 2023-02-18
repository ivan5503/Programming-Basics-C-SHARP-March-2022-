using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsAkad = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double actorPoints = 0.00;


            for (int i = 1; i <= n; i++)
            {
                string evaluatorName = Console.ReadLine();
                double pointsEval = double.Parse(Console.ReadLine());

                actorPoints = (evaluatorName.Length * pointsEval) / 2;
                pointsAkad += actorPoints;

                if (pointsAkad >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {(pointsAkad):f1}!");
                    return;
                }

            }
            Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - pointsAkad):f1} more!");
        }
    }
}
