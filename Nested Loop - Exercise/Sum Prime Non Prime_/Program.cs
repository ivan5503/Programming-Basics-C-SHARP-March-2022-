using System;

namespace Sum_Prime_Non_Prime_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int primeSum = 0;
            int nonPrimeSum = 0;
            int number = 0;


            while ((input = Console.ReadLine()) != "stop")
            {
                number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine($"Number is negative.");
                    continue;
                }
                else if (number == 0)
                {
                    nonPrimeSum += number;
                    continue;
                }
                bool isPrime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        nonPrimeSum += number;
                        break;


                    }



                }
                if (isPrime == true)
                {
                    primeSum += number;
                }


            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");

        }
    }
}
