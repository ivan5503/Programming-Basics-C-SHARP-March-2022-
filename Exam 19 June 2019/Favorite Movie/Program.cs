using System;

namespace Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            string bestMovie = "";
            int movieCounter = 0;
            int maxNumber = int.MinValue;
            int sum = 0;
            int small = 0;
            int big = 0;
            int letterCounter = 0;
            int sumSymbols = 0;


            while ((name = Console.ReadLine()) != "STOP")
            {
                movieCounter++;
                small = 0;
                big = 0;
                sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == 'a')
                    {
                        sum += 97;
                        small++;
                    }
                    else if (name[i] == 'e')
                    {
                        sum += 101;
                        small++;
                    }
                    else if (name[i] == 'i')
                    {
                        sum += 105;
                        small++;
                    }
                    else if (name[i] == 'o')
                    {
                        sum += 111;
                        small++;
                    }
                    else if (name[i] == 'u')
                    {
                        sum += 117;
                        small++;
                    }
                    else if (name[i] == 'y')
                    {
                        sum += 121;
                        small++;
                    }
                    else if (name[i] == 'T')
                    {
                        sum += 84;
                        big++;
                    }
                    else if (name[i] == 'h')
                    {
                        sum += 104;
                        small++;
                    }
                    else if (name[i] == 'M')
                    {
                        sum += 77;
                        big++;
                    }
                    else if (name[i] == 's')
                    {
                        sum += 115;
                        small++;
                    }
                    else if (name[i] == 't')
                    {
                        sum += 116;
                        small++;
                    }
                    else if (name[i] == 'P')
                    {
                        sum += 80;
                        big++;
                    }
                    else if (name[i] == 'w')
                    {
                        sum += 119;
                        small++;
                    }
                    else if (name[i] == 'F')
                    {
                        sum += 70;
                        big++;
                    }
                    else if (name[i] == 'f')
                    {
                        sum += 102;
                        small++;
                    }
                    else if (name[i] == 'l')
                    {
                        sum += 108;
                        small++;
                    }
                    else if (name[i] == 'r')
                    {
                        sum += 114;
                        small++;
                    }
                    else if (name[i] == 'd')
                    {
                        sum += 100;
                        small++;
                    }
                    else if (name[i] == 'D')
                    {
                        sum += 68;
                        big++;
                    }
                    else if (name[i] == 'W')
                    {
                        sum += 87;
                        big++;
                    }
                    else if (name[i] == 'I')
                    {
                        sum += 73;
                        big++;
                    }
                    else if (name[i] == 'B')
                    {
                        sum += 66;
                        big++;
                    }
                    else if (name[i] == 'S')
                    {
                        sum += 83;
                        big++;
                    }
                    else if (name[i] == 'm')
                    {
                        sum += 109;
                        small++;
                    }
                    else if (name[i] == 'p')
                    {
                        sum += 112;
                        small++;
                    }
                    else if (name[i] == 'L')
                    {
                        sum += 76;
                        big++;
                    }
                    else if (name[i] == 'O')
                    {
                        sum += 79;
                        big++;
                    }
                    else if (name[i] == 'V')
                    {
                        sum += 86;
                        big++;
                    }
                    else if (name[i] == 'E')
                    {
                        sum += 69;
                        big++;
                    }
                    else if (name[i] == 'x')
                    {
                        sum += 120;
                        small++;
                    }
                    else if (name[i] == 'n')
                    {
                        sum += 110;
                        small++;
                    }
                    else if (name[i] == 'c')
                    {
                        sum += 99;
                        small++;
                    }
                    else if (name[i] == '\'')
                    {
                        sum += 39;
                    }
                    else if (name[i] == 'A')
                    {
                        sum += 65;
                        big++;
                    }
                    else if (name[i] == 'U')
                    {
                        sum += 85;
                        big++;
                    }
                    else if (name[i] == 'Y')
                    {
                        sum += 89;
                        big++;
                    }
                    else if (name[i] == 'b')
                    {
                        sum += 98;
                        small++;
                    }
                    else if (name[i] == 'g')
                    {
                        sum += 103;
                        small++;
                    }
                    else if (name[i] == 'j')
                    {
                        sum += 106;
                        small++;
                    }
                    else if (name[i] == 'k')
                    {
                        sum += 107;
                        small++;
                    }
                    else if (name[i] == 'q')
                    {
                        sum += 113;
                        small++;
                    }
                    else if (name[i] == 'v')
                    {
                        sum += 118;
                        small++;
                    }
                    else if (name[i] == 'z')
                    {
                        sum += 122;
                        small++;
                    }
                    else if (name[i] == 'R')
                    {
                        sum += 82;
                        big++;
                    }
                    else if (name[i] == ' ')
                    {
                        sum += 32;

                    }
                    else if (name[i] == 'H')
                    {
                        sum += 72;
                        big++;
                    }
                    else if (name[i] == '2')
                    {
                        sum += 50;

                    }
                    else if (name[i] == 'K')
                    {
                        sum += 75;
                        big++;
                    }
                    else if (name[i] == 'Z')
                    {
                        sum += 90;
                        big++;
                    }
                    else if (name[i] == 'N')
                    {
                        sum += 78;
                        big++;
                    }



                }
                letterCounter = 2 * small + big;
                sumSymbols = sum - name.Length * letterCounter;
                if (sumSymbols > maxNumber)
                {


                    maxNumber = sumSymbols;
                    bestMovie = name;


                }
                if (movieCounter == 7)
                {
                    Console.WriteLine($"The limit is reached.");
                    break;
                }

            }
            Console.WriteLine($"The best movie for you is {bestMovie} with {maxNumber} ASCII sum.");
        }
    }
}
