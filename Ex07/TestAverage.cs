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
            
            // score출력
            for (int i =0; i< score.GetLength(0); i++)
            {
                for(int j = 0; j < score.GetLength(1); j++)
                {
                    Console.Write("{0,3}\t", score[i, j]);
                }
                // score 평균 출력
                getAverage(score,i);
                Console.WriteLine();
            }
            // test 평균 출력
            for(int j = 0; j<score.GetLength(1); j++)
                getTestAverage(score, j);
        }

        // score 평균 계산 함수
        void getAverage(int[,] arr, int i)
        {
            double sum = 0;
            for(int k = 0; k<arr.GetLength(1); k++)
            {
                sum += arr[i, k];
            }
            Console.Write("{0:N1}", sum / arr.GetLength(1));
        }

        // test 평균 계산 함수
        void getTestAverage(int[,] arr, int j)
        {
            double sum = 0;
            for(int l = 0; l<arr.GetLength(0); l++)
            {
                sum += arr[l, j];
            }
            Console.Write("{0:N1}\t", sum / arr.GetLength(0));
        }
    }
}
