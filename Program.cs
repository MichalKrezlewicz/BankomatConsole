using BankomatConsole.Menu;

namespace BankomatConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 20);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            //SimpleMenu.StartMenu();
            AdvancedMenu.StartMenu();

            //kUcLis tu był!
        }
    }
}