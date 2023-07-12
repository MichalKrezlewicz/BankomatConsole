using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatConsole.Menu
{
    static class SimpleMenu
    {
        public static void StartMenu()
        {
            Console.Title = "YourATM by Michał Krężlewicz";
            string menuOptions = @"
        Simply press the selected key.

        >>> 1 for cash withdrawal <<<
        >>> 2 for cash deposit <<<
        >>> 3 for balance check <<<
        >>> 4 to exit <<<";

            while (true)
            {
                Console.Clear();
                AsciiArt.DisplayAscii();
                Console.WriteLine(menuOptions);

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); underConstruction();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear(); underConstruction();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear(); underConstruction();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D4:
                        Environment.Exit(0);
                        break;
                    default: break;
                }
            }
        }
        static void underConstruction()
        {
            Console.WriteLine("This part of program is still under construction\n");
            Console.WriteLine(">>> PRESS ANY KEY TO EXIT <<<");
            Console.ReadKey();
        }
    }
}
