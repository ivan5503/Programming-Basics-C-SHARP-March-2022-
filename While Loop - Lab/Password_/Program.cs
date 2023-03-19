using System;

namespace Password_
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string word = Console.ReadLine();
            while (word != password)
            {
                word = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
