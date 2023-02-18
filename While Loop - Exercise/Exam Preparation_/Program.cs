using System;

namespace Exam_Preparation_
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());
            int evaluationCount = 0;
            double evaluationSum = 0;
            string lastExercises = string.Empty;

            int evaluation;
            int failedCount = 0;
            string input = Console.ReadLine();


            while (input != "Enough")
            {
                lastExercises = input;
                evaluation = int.Parse(Console.ReadLine());
                evaluationSum += evaluation;

                evaluationCount++;
                if (evaluation <= 4)
                {
                    failedCount++;
                    if (failedCount == failedTimes)
                    {
                        Console.WriteLine($"You need a break, {failedCount} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (failedCount < failedTimes)
            {
                Console.WriteLine($"Average score: {evaluationSum / evaluationCount:f2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercises}");
            }
        }
    }
}
