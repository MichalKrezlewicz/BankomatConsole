namespace BankomatConsole.Views
{
    public static class DepositCashView
    {
        //method below is for under construction view
        public static void depositCashViewUC()
        {
            Console.SetCursorPosition(4, 1);
            Console.WriteLine("Deposit cash option is still under construction");
            Console.SetCursorPosition(13, 3);
            Console.WriteLine(">>> PRESS ANY KEY TO EXIT <<<");
            Console.ReadKey();
        }

        //method below will be final
        public static void depositCashView(Account programAccount)
        {
            Console.SetCursorPosition(4, 1);
            Console.WriteLine("Please write the amount of money to deposit:");
            double amount = double.Parse(Console.ReadLine());
            Operations.IncreaseBalance(programAccount, amount);
            Console.SetCursorPosition(13, 3);
            Console.WriteLine(">>> PRESS ANY KEY TO EXIT <<<");
            Console.ReadKey();
        }
    }
}