using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int requiredHours = numberOfProjects * 3;
            Console.WriteLine($"The architect {nameOfArchitect} will need {requiredHours} hours to complete {numberOfProjects} project/s.");
        }
    }
}
