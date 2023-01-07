using System;

namespace Ex07
{
    class ReturnArray
    {
        int[] makeArray()
        {
            int[] temp = new int[4];
            for(int i=0;i<temp.Length;i++)
            {
                temp[i] = i;
            }
            return temp;
        }

        public void PrintReturnArray()
        {
            int[] intArray;
            intArray= makeArray();
            for(int i = 0; i<intArray.Length; i++)
                Console.Write(intArray[i] + " ");
            Console.WriteLine();
        }
    }
}