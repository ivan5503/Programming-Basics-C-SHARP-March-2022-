using System;

namespace Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int goals = 0;
            string bestPlayer = "";
            int maxNumber = int.MinValue;

            while ((name = Console.ReadLine()) != "END")
            {
                goals = int.Parse(Console.ReadLine());

                if (goals > maxNumber)
                {
                    maxNumber = goals;
                    bestPlayer = name;
                    if (maxNumber >= 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (maxNumber >= 3)
            {
                Console.WriteLine($"He has scored {maxNumber} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxNumber} goals.");
            }
        }
    }
}
