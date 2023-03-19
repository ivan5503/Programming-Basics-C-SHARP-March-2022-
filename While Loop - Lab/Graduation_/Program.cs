using System;

namespace Graduation_
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int assessmentCounter = 0;
            double averageAssessment = 0;
            int yearCounter = 0;
            int y = 1;
            while (y <= 12)
            {
                y++;
                yearCounter++;
                double annualAssessment = double.Parse(Console.ReadLine());
                averageAssessment += annualAssessment;
                if (annualAssessment < 4)
                {
                    assessmentCounter++;
                    if (assessmentCounter == 2)
                    {
                        yearCounter--;
                        Console.WriteLine($"{name} has been excluded at {yearCounter} grade");
                        return;

                    }

                }
            }
            averageAssessment = averageAssessment / yearCounter;
            Console.WriteLine($"{name} graduated. Average grade: {averageAssessment:f2}");
        }
    }
}
