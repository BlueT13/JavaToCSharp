using System;

namespace Ex07
{
    internal class ScoreAverage
    {
        public void PrintScoreAverage()
        {
            double[,] score = new double[4, 2] { { 3.3, 3.4 }, { 3.5, 3.6 }, { 3.7, 4.0 }, { 4.1, 4.2 } };
            double sum = 0;

            for(int year = 0; year < score.GetLength(0); year++)
            {
                for(int term = 0; term < score.GetLength(1); term++)
                {
                    sum += score[year, term];
                }
            }

            int n = score.GetLength(0);
            int m = score.GetLength(1);
            Console.WriteLine("Average: " + sum / (n * m));
        }
    }
}
