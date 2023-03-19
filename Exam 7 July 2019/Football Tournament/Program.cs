using System;

namespace Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int playedMatches = int.Parse(Console.ReadLine());
            int counterW = 0;
            int counterD = 0;
            int counterL = 0;
            int sumPointsW = 0;



            for (int i = 0; i < playedMatches; i++)
            {

                string result = Console.ReadLine();
                for (int r = 0; r < result.Length; r++)
                {

                    char letter = result[r];
                    if (result[r] == 'W')
                    {
                        counterW++;
                        sumPointsW += 3;
                    }
                    else if (result[r] == 'D')
                    {
                        counterD++;
                    }
                    else
                    {
                        counterL++;
                    }
                }



            }
            if (playedMatches == 0)
            {
                Console.WriteLine($"{name} hasn't played any games during this season.");

            }
            else
            {
                Console.WriteLine($"{name} has won {sumPointsW + counterD} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {counterW}");
                Console.WriteLine($"## D: {counterD}");
                Console.WriteLine($"## L: {counterL}");
                Console.WriteLine($"Win rate: {counterW * 100.0 / playedMatches:f2}% ");
            }
        }
    }
}
