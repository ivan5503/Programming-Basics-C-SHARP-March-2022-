using System;

namespace Invalid_Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isValidNumber = number >= 100 && number <= 200 || number == 0;
            if (isValidNumber)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
