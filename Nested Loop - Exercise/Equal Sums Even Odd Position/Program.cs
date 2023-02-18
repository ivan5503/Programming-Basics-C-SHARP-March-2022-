using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());

            for (int i = firstN; i <= secondN; i++)
            {
                string currentN = i.ToString();
                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < currentN.Length; j++)
                {
                    int currentJ = int.Parse(currentN[j].ToString());
                    if (j % 2 == 0)
                    {
                        oddSum += currentJ;
                    }
                    else
                    {
                        evenSum += currentJ;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
