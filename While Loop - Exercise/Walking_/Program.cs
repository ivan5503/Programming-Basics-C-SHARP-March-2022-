using System;

namespace Walking_
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyStepsGoal = 10000;
            int steps = 0;
            int stepsForTheDay = 0;
            string text = "";

            while (stepsForTheDay < dailyStepsGoal)
            {

                text = Console.ReadLine();
                if (text == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    stepsForTheDay += lastSteps;
                    break;
                }
                steps = int.Parse(text);
                stepsForTheDay += steps;

            }
            if (stepsForTheDay >= dailyStepsGoal)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepsForTheDay - dailyStepsGoal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{dailyStepsGoal - stepsForTheDay} more steps to reach goal.");
            }
        }
    }
}
