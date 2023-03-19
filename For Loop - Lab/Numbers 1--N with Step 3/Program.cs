using System;

namespace Numbers_1__N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 3;
            for (int i = 1; i <= n; i++)
            {
                if (counter == 3)
                {
                    Console.WriteLine(i);
                    counter = 0;
                }
                counter++;
            }
        }
    }
}
