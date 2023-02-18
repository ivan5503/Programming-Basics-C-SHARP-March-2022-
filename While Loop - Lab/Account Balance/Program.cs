using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            double instalment = 0;
            string input;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                 instalment = double.Parse(input);
                if (instalment < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += instalment;
                Console.WriteLine($"Increase: {instalment:f2}");
            }
            Console.WriteLine($"Total: {balance:f2}");

           
        }
    }
}
