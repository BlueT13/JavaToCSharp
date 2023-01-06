using System;

namespace Ex06
{
    internal class Ex06_6
    {
        public void PrintEx06_6()
        {
            string str = Console.ReadLine();
            string[] input = str.Split(' ');
            int[] parity = new int[8];
            int[] evenparity = new int[9];
            int count = 0;

            for(int i = 0; i < parity.Length; i++)
            {
                parity[i] = Convert.ToInt32(input[i]);
                if (parity[i] == 1)
                    count++;
            }

            for(int j = 0; j < parity.Length; j++)
            {
                if (count % 2 == 0)
                {
                    evenparity[j] = parity[j];
                    evenparity[8] = 0;
                }

                else
                {
                    evenparity[j] = parity[j];
                    evenparity[8] = 1;
                }
            }

            for(int k = 0; k< evenparity.Length; k++)
            {
                Console.Write(evenparity[k]+" ");
            }
        }
        
    }
}
