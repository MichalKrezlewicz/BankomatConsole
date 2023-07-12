using BankomatConsole.BankomatConsole;

namespace BankomatConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 20);


            //ConsoleMenu consoleMenu = new ConsoleMenu();
            //consoleMenu.Run();

            SimpleMenu.StartSimpleMenu();
        }
    }
}