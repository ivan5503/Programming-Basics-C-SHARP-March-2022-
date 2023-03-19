using System;

namespace Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableSum = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double sum = 0;

            if (gender == "m")
            {
                if (sport == "Gym")
                {
                    if (age <= 19)
                    {
                        sum = 42 - (42 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 42;
                    }
                }
                else if (sport == "Boxing")
                {
                    if (age <= 19)
                    {
                        sum = 41 - (41 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 41;
                    }
                }
                else if (sport == "Yoga")
                {
                    if (age <= 19)
                    {
                        sum = 45 - (45 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 45;
                    }
                }
                else if (sport == "Zumba")
                {

                    if (age <= 19)
                    {
                        sum = 34 - (34 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 34;
                    }
                }
                else if (sport == "Dances")
                {

                    if (age <= 19)
                    {
                        sum = 51 - (51 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 51;
                    }
                }
                else
                {

                    if (age <= 19)
                    {
                        sum = 39 - (39 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 39;
                    }
                }

            }
            else if (gender == "f")
            {

                if (sport == "Gym")
                {

                    if (age <= 19)
                    {
                        sum = 35 - (35 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 35;
                    }
                }
                else if (sport == "Boxing")
                {

                    if (age <= 19)
                    {
                        sum = 37 - (37 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 37;

                    }
                }
                else if (sport == "Yoga")
                {
                    if (age <= 19)
                    {
                        sum = 42 - (42 * 20 / 100.0);
                        sum = availableSum - sum;

                    }
                    else
                    {
                        sum = availableSum - 42;
                    }
                }
                else if (sport == "Zumba")
                {

                    if (age <= 19)
                    {
                        sum = 31 - (31 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 31;
                    }
                }
                else if (sport == "Dances")
                {

                    if (age <= 19)
                    {
                        sum = 53 - (53 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 53;
                    }
                }
                else
                {

                    if (age <= 19)
                    {
                        sum = 37 - (37 * 0.2);
                        sum = availableSum - sum;
                    }
                    else
                    {
                        sum = availableSum - 37;
                    }
                }
            }
            if (sum >= 0)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum):f2} more.");
            }
        }
    }
}
