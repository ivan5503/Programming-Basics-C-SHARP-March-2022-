using System;

namespace Min_Number_
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            int currentNumber = 0;
            string text;
            while ((text = Console.ReadLine()) != "Stop")
            {

                currentNumber = int.Parse(text);
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }

            }
            Console.WriteLine(minNumber);
        }
    }
}
