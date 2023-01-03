using System;

namespace Ex02
{
    internal class Addition2
    {
        public void PrintAdditioin2()
        {
            int number1;
            int number2;
            int sum;

            Console.Write("Enter first integer: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;
            string sum8 = Convert.ToString(sum, 8);
            string sum16 = Convert.ToString(sum, 16);

            Console.Write("Sum is {0} in octal, {1} in decimal, {2} in hexadecimal.", sum8, sum, sum16);
        }
    }
}
