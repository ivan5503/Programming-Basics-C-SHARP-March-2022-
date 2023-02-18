using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int piecesSideA = int.Parse(Console.ReadLine());
            int piecesSideB = int.Parse(Console.ReadLine());
            int piecesOfCake = piecesSideA * piecesSideB;
            string text = "";
            int takedPieces = 0;
            
            int counter = 0;

            while (true)
            {
                text = Console.ReadLine();
                if (text == "STOP")
                {
                    Console.WriteLine($"{piecesOfCake} pieces are left.");
                    break;
                }
                  piecesOfCake -= takedPieces = int.Parse(text);
                  counter++;
                if (piecesOfCake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesOfCake)} pieces more.");
                    break;
                }
                
            }
          
        }
    }
}
