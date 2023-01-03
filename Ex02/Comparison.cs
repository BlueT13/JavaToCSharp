using System;

namespace Ex02
{
    internal class Comparison
    {
        public void PrintComparison()
        {
            int number1;
            int number2;

            Console.Write("Enter first integer: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = int.Parse(Console.ReadLine());

            if(number1 == number2)
                Console.Write("{0} == {1}\n", number1,number2);

            if (number1 != number2)
                Console.Write("{0} != {1}\n", number1, number2);

            if (number1 < number2)
                Console.Write("{0} < {1}\n", number1, number2);

            if (number1 > number2)
                Console.Write("{0} > {1}\n", number1, number2);

            if (number1 <= number2)
                Console.Write("{0} <= {1}\n", number1, number2);

            if (number1 >= number2)
                Console.Write("{0} >= {1}\n", number1, number2);
        }
    }
}
