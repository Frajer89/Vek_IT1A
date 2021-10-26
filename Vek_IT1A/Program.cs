using System;

namespace Vek_IT1A
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            
            
            Console.SetCursorPosition(30, 15);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("╔═══════════════════════╗");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(30, 16);
            Console.Write("║Zadej svůj rok narození║");
            
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(30, 17);
            Console.Write("╚═══════════════════════╝");

           


            Console.ReadLine();
        }
    }
}
