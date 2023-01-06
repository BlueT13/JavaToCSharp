using System;

namespace Ex07
{
    internal class Foreach
    {
        public void PrintForeach()
        {
            int[] num = new int[5] { 1, 2, 3, 4, 5 };
            int sum = 0;
            string[] names = {"apple", "pear", "banana", "cherry",
                                "strawberry", "grapes" };
            string[] days = { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };

            foreach(int i in num)
            {
                sum += i;
            }
            Console.Write("Sum: "+sum);
            Console.WriteLine();

            foreach(string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            foreach(string day in days)
            {
                Console.Write(day + " ");
            }
        }
    }
}
