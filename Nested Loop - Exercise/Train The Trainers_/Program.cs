using System;

namespace Train_The_Trainers_
{
    class Program
    {
        static void Main(string[] args)
        {
            int juriNum = int.Parse(Console.ReadLine());
            string namePre = Console.ReadLine();
            double evaluation = 0;
            double averageOfAll = 0;
            int presentationCounter = 0;


            while (namePre != "Finish")
            {

                presentationCounter++;
                double averageEva = 0;
                double evaluationSum = 0;

                int counterEva = 0;
                while (counterEva != juriNum)
                {
                    evaluation = double.Parse(Console.ReadLine());
                    evaluationSum += evaluation;

                    counterEva++;
                }
                averageEva = evaluationSum / juriNum;
                averageOfAll += averageEva;
                Console.WriteLine($"{namePre} - {averageEva:f2}.");
                namePre = Console.ReadLine();

            }
            Console.WriteLine($"Student's final assessment is {averageOfAll / presentationCounter:f2}.");
        }
    }
}
