using System;

namespace Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double actorsBudget = double.Parse(Console.ReadLine());
            string actorName = "";
            double sallary = 0;


            while ((actorName = Console.ReadLine()) != "ACTION")
            {

                if (actorName.Length <= 15)
                {

                    sallary = double.Parse(Console.ReadLine());
                    actorsBudget -= sallary;

                    if (actorsBudget < 0)
                    {
                        Console.WriteLine($"We need {Math.Abs(actorsBudget):f2} leva for our actors.");
                        break;
                    }
                }

                if (actorName.Length > 15)
                {

                    sallary = actorsBudget * 0.2;
                    actorsBudget -= sallary;

                    if (actorsBudget < 0)
                    {
                        Console.WriteLine($"We need {Math.Abs(actorsBudget):f2} leva for our actors.");
                        break;
                    }


                }

            }
            if (actorsBudget >= 0)
            {
                Console.WriteLine($"We are left with {actorsBudget:f2} leva.");
            }
        }
    }
}
