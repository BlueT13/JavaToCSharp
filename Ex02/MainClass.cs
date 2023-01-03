using System;

namespace Ex02
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Welcome2 welcome2 = new Welcome2();
            welcome2.PrintWelcome2();
            Console.WriteLine();

            Welcome3 welcome3 = new Welcome3();
            welcome3.PrintWelcome3();
            Console.WriteLine();

            Welcome4 welcome4 = new Welcome4();
            welcome4.PrintWelcome4();
            Console.WriteLine();

            Addition addition = new Addition();
            addition.PrintAddition();
            Console.WriteLine();

            Comparison comparison = new Comparison();
            comparison.PrintComparison();
            Console.WriteLine();

            Addition2 addition2 = new Addition2();
            addition2.PrintAdditioin2();
            
        }
    }
}
