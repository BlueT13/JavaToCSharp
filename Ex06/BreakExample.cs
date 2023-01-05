using System;

namespace Ex06
{
    internal class BreakExample
    {
        public void PrintBreakExample()
        {
            Console.WriteLine("Type exit to terminate.");
            
            while(true)
            {
                Console.Write(">> ");
                string exit = Console.ReadLine();
                if (exit == "exit")
                {
                    Console.Write("Terminating...");
                    break;
                }
            }
        }
    }
}
