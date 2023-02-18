using System;

namespace Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {

            for (; ; )
            {
                string word = Console.ReadLine();
                if (word == "Stop")
                {
                    break;
                }
                Console.WriteLine(word);
            }

        }
    }
}
