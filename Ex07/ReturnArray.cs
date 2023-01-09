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
            intArray = makeArray(); //intArray에 temp배열의 시작 주소값(&[0])을 대입
            for(int i = 0; i<intArray.Length; i++)
                Console.Write(intArray[i] + " ");
            Console.WriteLine();
        }
    }
}