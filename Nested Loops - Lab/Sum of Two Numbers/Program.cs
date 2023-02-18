using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginingOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());
            int theMagicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            
            for (int x = beginingOfInterval; x <= endOfInterval; x++)
            {
                for (int y = beginingOfInterval; y <= endOfInterval; y++)
                {
                    combination++;
                    if (x + y == theMagicNumber)
                    {
                        
                        Console.WriteLine($"Combination N:{combination} ({x} + {y} = {theMagicNumber})");
                        return;

                        
                    }
                  
                }
               

            }
            
            
                Console.WriteLine($"{combination} combinations - neither equals {theMagicNumber}");
            
            
        }
    }

}
