using System;

namespace Ex07
{
    internal class TestAverage
    {
        public void PrintTestAverage()
        {
            
            int[,] score =  { { 87, 96, 70 },
                              { 68, 87, 90 },
                              { 94, 100, 90 },
                              { 100, 81, 82 },
                              { 83, 65, 85 },
                              { 78, 87, 65 },
                              { 85, 75, 83 },
                              { 91, 94, 100 },
                              { 76, 72, 84 },
                              { 87, 93, 73 } };
            double sum = 0;
            double sum2 = 0;

            // score출력
            for(int i =0; i< score.GetLength(0); i++)
            {
                for(int j = 0; j < score.GetLength(1); j++)
                {
                    Console.Write("{0,3}\t", score[i, j]);
                    sum += score[i, j];
                }
                // score 평균 출력
                Console.Write("{0:N1}", sum / 3);
                sum = 0;
                Console.WriteLine();
            }

            // test 평균 출력
            for(int m = 0; m < score.GetLength(1); m++)
            {
                for (int k = 0; k < score.GetLength(0); k++)
                {
                    sum2 += score[k, m];
                }
                Console.Write("{0:N1}\t", sum2 / score.GetLength(0));
                sum2 = 0;
            }
        }
    }
}
