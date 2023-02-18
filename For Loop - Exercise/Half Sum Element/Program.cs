using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumOfTheRest = 0;
            int maxNumber = int.MinValue;
            int numberOfUsers = 0;
            for (int i = 1; i <= n; i++)
            {
                numberOfUsers = int.Parse(Console.ReadLine());

                sumOfTheRest += numberOfUsers;

                if (numberOfUsers > maxNumber)
                {
                    maxNumber = numberOfUsers;
                }

            }
            sumOfTheRest = sumOfTheRest - maxNumber;
            if (sumOfTheRest == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOfTheRest}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOfTheRest - maxNumber)}");
            }
        }
    }
}
