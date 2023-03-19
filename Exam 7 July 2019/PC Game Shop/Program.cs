using System;

namespace PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSoldGames = int.Parse(Console.ReadLine());
            string titel = "";
            int hearthstoneCounter = 0;
            int forniteCounter = 0;
            int overwatchCounter = 0;
            int othersCounter = 0;
            for (int i = 1; i <= numSoldGames; i++)
            {
                titel = Console.ReadLine();

                if (titel == "Hearthstone")
                {
                    hearthstoneCounter++;
                }
                else if (titel == "Fornite")
                {
                    forniteCounter++;
                }
                else if (titel == "Overwatch")
                {
                    overwatchCounter++;
                }
                else
                {
                    othersCounter++;
                }

            }
            Console.WriteLine($"Hearthstone - {hearthstoneCounter * 100.0 / numSoldGames:f2}%");
            Console.WriteLine($"Fornite - {forniteCounter * 100.0 / numSoldGames:f2}%");
            Console.WriteLine($"Overwatch - {overwatchCounter * 100.0 / numSoldGames:f2}%");
            Console.WriteLine($"Others - {othersCounter * 100.0 / numSoldGames:f2}%");
        }
    }
}
