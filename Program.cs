using BankomatConsole.BankomatConsole;

namespace BankomatConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 20);

            AsciiArt asciiArt = new AsciiArt();
            asciiArt.DisplayAscii();

            //ConsoleMenu consoleMenu = new ConsoleMenu();
            //consoleMenu.Run();
        }
    }
}