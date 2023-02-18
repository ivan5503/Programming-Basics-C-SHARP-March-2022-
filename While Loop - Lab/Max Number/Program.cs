using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            int currentNumber = 0;
            string text;
            while (true)
            {
                text = Console.ReadLine();
                if (text == "Stop")
                {
                    break;
                }
                currentNumber = int.Parse(text);
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }


            }
            Console.WriteLine(maxNumber);
        }
    }
}
