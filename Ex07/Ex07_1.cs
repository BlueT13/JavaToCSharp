using System;

namespace Ex07
{
    internal class Ex07_1
    {
        public void PrintEx07_1()
        {
            int[,] parity = { { 1, 0, 1, 0, 1, 1, 1, 1 }, 
                              { 1, 0, 0, 0, 0, 0, 1, 1 }, 
                              { 0, 1, 0, 0, 0, 0, 0, 0 }, 
                              { 1, 1, 1, 1, 0, 0, 0, 0 }, 
                              { 1, 0, 1, 1, 1, 0, 0, 1 }, 
                              { 0, 0, 0, 0, 0, 1, 1, 1 }, 
                              { 1, 1, 1, 1, 1, 1, 1, 1 }, 
                              { 0, 1, 1, 1, 1, 0, 0, 0 } };
            int sum = 0;
            int sum2 = 0;
            int count = 0;
            
            // 세로 방향 패리티 비트 출력
            for(int i=0;i<parity.GetLength(0);i++)
            {
                for(int j=0;j<parity.GetLength(1);j++)
                {
                    Console.Write(parity[i,j]+" ");
                    sum += parity[i, j];
                }
                if (sum % 2 == 0)
                    Console.Write("0");
                else
                {
                    Console.Write("1");
                    count++;
                }
                sum = 0;
                Console.WriteLine();
            }

            // 가로 방향 패리티 비트 출력
            for(int j=0; j<parity.GetLength(1);j++)
            {
                for (int i = 0; i < parity.GetLength(0); i++)
                {
                    sum2 += parity[i, j];
                }
                if (sum2 % 2 == 0)
                    Console.Write("0 ");
                else
                    Console.Write("1 ");
                sum2 = 0;
            }

            // 마지막 행과 열의 원소
            if (count % 2 == 0)
                Console.Write("0");
            else
                Console.Write("1");
        }
    }
}
