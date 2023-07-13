namespace BankomatConsole.Views
{
    public static class CkeckBalanceView
    {
        //method below is for under construction view
        public static void ckeckBalanceViewUC()
        {
            Console.SetCursorPosition(4, 1);
            Console.WriteLine("Check Balance option is still under construction");
            Console.SetCursorPosition(13, 3);
            Console.WriteLine(">>> PRESS ANY KEY TO EXIT <<<");
            Console.ReadKey();
        }

        //method below will be final
        public static void ckeckBalanceView()
        {
            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"Your account balance {Account.ShowBalance()}");
            Console.SetCursorPosition(13, 3);
            Console.WriteLine(">>> PRESS ANY KEY TO EXIT <<<");
            Console.ReadKey();
        }
    }
}
