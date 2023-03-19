using System;

namespace Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int moviesNum = int.Parse(Console.ReadLine());
            double maxNumber = int.MinValue;
            double minNumber = int.MaxValue;
            double averageRatingSum = 0;

            string maxRatingFilm = "";
            string minRatingFilm = "";

            for (int i = 1; i <= moviesNum; i++)
            {
                string filmName = Console.ReadLine();

                double currentRating = double.Parse(Console.ReadLine());
                averageRatingSum += currentRating;

                if (currentRating > maxNumber)
                {
                    maxNumber = currentRating;
                    maxRatingFilm = filmName;
                }
                if (currentRating < minNumber)
                {
                    minNumber = currentRating;
                    minRatingFilm = filmName;
                }


            }
            Console.WriteLine($"{maxRatingFilm} is with highest rating: {maxNumber:f1}");
            Console.WriteLine($"{minRatingFilm} is with lowest rating: {minNumber:f1}");
            Console.WriteLine($"Average rating: {averageRatingSum / moviesNum:f1}");
        }
    }
}
