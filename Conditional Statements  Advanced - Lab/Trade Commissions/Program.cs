using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            
            double commission = 0.00;
            
            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.05;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.07;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.08;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.12;
                    Console.WriteLine($"{commission:f2}");
                }
                else
                {
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                }
            } 
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.045;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.075;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.1;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.13;
                    Console.WriteLine($"{commission:f2}");
                }
                else
                {
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.055;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.08;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.12;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.145;
                    Console.WriteLine($"{commission:f2}");
                }
                else
                {
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
