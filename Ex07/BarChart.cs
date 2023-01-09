using System;

namespace Ex07
{
    internal class BarChart
    {
        public void PrintBarChar()
        {
            int[] data = new int[] { 5, 2, 18, 9, 6, 11, 4, 5, 13, 7 };
            foreach(int n in data)
            {
                Console.Write("{0,2} ",n); // {0,2}사용해서 한 자리 수와 두 자리 수 정렬
                for(int i = 0; i<n;i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
