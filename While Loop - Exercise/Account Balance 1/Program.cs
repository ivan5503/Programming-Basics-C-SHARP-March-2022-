using System;

namespace Account_Balance 
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            double payment = 0;
            int invalidNumber = 0;
            string command = "";

            while (true)
            {
                command = Console.ReadLine();
                if (command == "NoMoreMoney")
                {
                    break;
                }
                payment = double.Parse(command);

                if (payment < invalidNumber)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalSum += payment;
                Console.WriteLine($"Increase: {payment:f2}");
            }
            Console.WriteLine($"Total: {totalSum:f2}");
            

        }
    }
}