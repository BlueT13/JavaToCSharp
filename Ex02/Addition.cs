using System;

namespace Ex02
{
    internal class Addition
    {
        public void PrintAddition()
        {
            int number1;
            int number2;
            int sum;

            Console.Write("Enter first integer: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1+ number2;
            Console.Write("Sum is {0}\n", sum);
            //Console.Write("Sum is " + sum);
        }
    }
}
