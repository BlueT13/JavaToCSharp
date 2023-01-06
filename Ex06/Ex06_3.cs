using System;

namespace Ex06
{
    internal class Ex06_3
    {
        public void PrintEx06_3()
        {
            int[] responses = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10,
                                1, 6, 3, 8, 6, 10, 3, 8, 2, 7,
                                6, 5, 7, 6, 8, 7, 5, 6, 6, 5,
                                6, 7, 5, 6, 4, 8, 6, 8, 10, 6};
            int[] count = new int[10];

            Console.WriteLine("Rating\tFrequency");
            for(int i =0; i<10; i++)
            {
                for(int j=0; j<responses.Length; j++)
                {
                    if (responses[j] == i+1)
                        count[i]++;
                }
                Console.WriteLine("{0}\t{1}", i+1, count[i]);
            }
        }
        
    }
}
