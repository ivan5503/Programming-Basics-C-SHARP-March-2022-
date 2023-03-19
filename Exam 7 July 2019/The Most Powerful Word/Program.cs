using System;

namespace The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string greatestWord = "";
            int sum = 0;
            int wordPower = 0;
            int vowelCounter = 0;
            double maxNumber = int.MinValue;


            while ((name = Console.ReadLine()) != "End of words")
            {


                for (int i = 0; i < name.Length; i++)
                {
                    char currenL = name[i];
                    if (i == 0)
                    {
                        if (name[i] == 'A' || name[i] == 'E' || name[i] == 'I' || name[i] == 'O' || name[i] == 'U' || name[i] == 'Y')
                        {
                            vowelCounter++;
                        }
                        else if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u' || name[i] == 'y')
                        {
                            vowelCounter++;
                        }

                    }
                    if (name[i] == 'a')
                    {
                        sum += 97;
                    }
                    else if (name[i] == 'e')
                    {
                        sum += 101;
                    }
                    else if (name[i] == 'i')
                    {
                        sum += 105;
                    }
                    else if (name[i] == 'o')
                    {
                        sum += 111;
                    }
                    else if (name[i] == 'u')
                    {
                        sum += 117;
                    }
                    else if (name[i] == 'y')
                    {
                        sum += 121;
                    }
                    else if (name[i] == 'T')
                    {
                        sum += 84;
                    }
                    else if (name[i] == 'h')
                    {
                        sum += 104;
                    }
                    else if (name[i] == 'M')
                    {
                        sum += 77;
                    }
                    else if (name[i] == 's')
                    {
                        sum += 115;
                    }
                    else if (name[i] == 't')
                    {
                        sum += 116;
                    }
                    else if (name[i] == 'P')
                    {
                        sum += 80;
                    }
                    else if (name[i] == 'w')
                    {
                        sum += 119;
                    }
                    else if (name[i] == 'f')
                    {
                        sum += 102;
                    }
                    else if (name[i] == 'l')
                    {
                        sum += 108;
                    }
                    else if (name[i] == 'r')
                    {
                        sum += 114;
                    }
                    else if (name[i] == 'd')
                    {
                        sum += 100;
                    }
                    else if (name[i] == 'W')
                    {
                        sum += 87;
                    }
                    else if (name[i] == 'I')
                    {
                        sum += 73;
                    }
                    else if (name[i] == 'B')
                    {
                        sum += 66;
                    }
                    else if (name[i] == 'S')
                    {
                        sum += 83;
                    }
                    else if (name[i] == 'm')
                    {
                        sum += 109;
                    }
                    else if (name[i] == 'p')
                    {
                        sum += 112;
                    }
                    else if (name[i] == 'L')
                    {
                        sum += 76;
                    }
                    else if (name[i] == 'O')
                    {
                        sum += 79;
                    }
                    else if (name[i] == 'V')
                    {
                        sum += 86;
                    }
                    else if (name[i] == 'E')
                    {
                        sum += 69;
                    }
                    else if (name[i] == 'x')
                    {
                        sum += 120;
                    }
                    else if (name[i] == 'n')
                    {
                        sum += 110;
                    }
                    else if (name[i] == 'c')
                    {
                        sum += 99;
                    }
                    else if (name[i] == '\'')
                    {
                        sum += 39;
                    }
                    else if (name[i] == 'A')
                    {
                        sum += 65;
                    }
                    else if (name[i] == 'U')
                    {
                        sum += 85;
                    }
                    else if (name[i] == 'Y')
                    {
                        sum += 89;
                    }
                    else if (name[i] == 'b')
                    {
                        sum += 98;
                    }
                    else if (name[i] == 'g')
                    {
                        sum += 103;
                    }
                    else if (name[i] == 'j')
                    {
                        sum += 106;
                    }
                    else if (name[i] == 'k')
                    {
                        sum += 107;
                    }
                    else if (name[i] == 'q')
                    {
                        sum += 113;
                    }
                    else if (name[i] == 'v')
                    {
                        sum += 118;
                    }
                    else if (name[i] == 'z')
                    {
                        sum += 122;
                    }


                }
                if (vowelCounter == 1)
                {
                    wordPower = sum * name.Length;
                }
                else
                {
                    wordPower = sum / name.Length;
                }
                vowelCounter = 0;
                if (wordPower > maxNumber)
                {
                    maxNumber = wordPower;
                    greatestWord = name;
                }

                sum = 0;

            }
            Console.WriteLine($"The most powerful word is {greatestWord} - {Math.Floor(maxNumber)}");
        }
    }
}
