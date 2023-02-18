using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int number = 0;
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (text != "stop")
            {
                number = int.Parse(text);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    text = Console.ReadLine();
                    continue;
                }
                bool isPrime = true;
                
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeSum += number;
                }
                else
                {
                    nonPrimeSum += number;
                }
                  text = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");

        }
    }
}
