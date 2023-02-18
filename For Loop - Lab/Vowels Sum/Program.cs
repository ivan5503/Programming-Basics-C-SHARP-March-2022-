using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();


            int sum = 0;
            
            for (int i = 0; i < name.Length; i++)
            {
                char currentLetter = name[i];
                if (currentLetter == 'a') 
                {
                    sum += 1;
                }
                else if (currentLetter == 'e')
                {
                    sum += 2;
                }
                else if (currentLetter == 'i')
                {
                    sum += 3;
                }
                else if (currentLetter == 'o')
                { 
                    sum += 4;
                }
                else if (currentLetter == 'u')
                {
                    sum += 5;
                }
                                  
            }
            Console.WriteLine(sum);
        }
    }
}
