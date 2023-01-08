using System;

namespace Ex07
{
    internal class Calc
    {
        public void PrintCalc(string[] args)
        {
            double sum = 0.0;

            for(int i =0;i<args.Length; i++)
            {
                sum += Double.Parse(args[i]);
            }
            Console.WriteLine("sum = " + sum);
        }
    }
}
