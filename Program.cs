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
            Account programAccount = new Account(1);
            
            
            Operations.IncreaseBalance(programAccount, 1000);
            //Operations.ShowBalance(programAccount);


            //SimpleMenu.StartMenu();
            AdvancedMenu.StartMenu(programAccount);
        }
    }
}