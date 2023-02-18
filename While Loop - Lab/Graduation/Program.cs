using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
                        
                        
            }
  

        }
    }
}