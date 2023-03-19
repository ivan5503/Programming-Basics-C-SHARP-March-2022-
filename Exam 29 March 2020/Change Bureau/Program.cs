using System;

namespace Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinNumber = int.Parse(Console.ReadLine());
            double yoanNumber = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());
            int bitcoinInLeva = bitcoinNumber * 1168;

            double yoanInDollar = yoanNumber * 0.15;
            double dollarInLeva = yoanInDollar * 1.76;
            double levaSum = dollarInLeva + bitcoinInLeva;
            double levaInEuro = levaSum / 1.95;

            double result = levaInEuro - (levaInEuro * comission / 100);
            Console.WriteLine($"{result:f2}");

        }
    }
}
