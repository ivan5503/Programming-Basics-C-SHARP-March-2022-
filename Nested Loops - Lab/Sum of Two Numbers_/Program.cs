using System;

namespace Sum_of_Two_Numbers_
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalA = int.Parse(Console.ReadLine());
            int intervalB = int.Parse(Console.ReadLine());
            int magicNumb = int.Parse(Console.ReadLine());
            int magicCounter = 0;
            bool isValidCombination = false;

            for (int i = intervalA; i <= intervalB; i++)
            {
                for (int k = intervalA; k <= intervalB; k++)
                {
                    magicCounter++;
                    if (i + k == magicNumb)
                    {
                        isValidCombination = true;
                        Console.WriteLine($"Combination N:{magicCounter} ({i} + {k} = {magicNumb})");
                        return;

                    }
                }
            }
            if (!isValidCombination)
            {
                Console.WriteLine($"{magicCounter} combinations - neither equals {magicNumb}");
            }
        }
    }
}
