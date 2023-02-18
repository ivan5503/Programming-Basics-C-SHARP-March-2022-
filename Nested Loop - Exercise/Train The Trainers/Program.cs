using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double presentationEv = 0;
            int presentationCount = 0;
            double evaluation = 0;

            while (input != "Finish")
            {
                presentationEv = 0;
                for (int i = 1; i <= number; i++)
                {
                    presentationEv += double.Parse(Console.ReadLine());
                }

                presentationEv = presentationEv / number;
                Console.WriteLine($"{input} - {presentationEv:f2}.");

                evaluation += presentationEv;
                presentationCount++;
                input = Console.ReadLine();
            }
            evaluation = evaluation / presentationCount;

            Console.WriteLine($"Student's final assessment is {evaluation:f2}.");
        }
    }
}
