using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsNumber = int.Parse(Console.ReadLine());
            int peopleNumber = 0;
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            double allClimbers = 0;

            for (int i = 1; i <= groupsNumber; i++)
            {
                peopleNumber = int.Parse(Console.ReadLine());

                if (peopleNumber <= 5)
                {
                    musala += peopleNumber;

                }
                else if (peopleNumber >= 6 && peopleNumber <= 12)
                {
                    monblan += peopleNumber;
                }
                else if (peopleNumber >= 13 && peopleNumber <= 25)
                {
                    kilimandjaro += peopleNumber;
                }
                else if (peopleNumber >= 26 && peopleNumber <= 40)
                {
                    k2 += peopleNumber;
                }
                else if (peopleNumber >= 41)
                {
                    everest += peopleNumber;
                }


            }
            allClimbers = musala + monblan + kilimandjaro + k2 + everest;
            musala = musala * 100.0 / allClimbers;
            monblan = monblan * 100.0 / allClimbers;
            kilimandjaro = kilimandjaro * 100.0 / allClimbers;
            k2 = k2 * 100.0 / allClimbers;
            everest = everest * 100.0 / allClimbers;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{kilimandjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");
        }
    }
}
