namespace BankomatConsole.Views
{
    public static class WithdrawMoneyView
    {
        //method below is for under construction view
        public static void withdrawMoneyViewUC()
        {
            Console.SetCursorPosition(4, 1);
            Console.WriteLine("Withdraw cash option is still under construction");
            Console.SetCursorPosition(13, 3);
            Console.WriteLine(">>> PRESS ANY KEY TO EXIT <<<");
            Console.ReadKey();
        }

        //method below will be final
        public static void withdrawMoneyView()
        {
            Console.SetCursorPosition(4, 1);
            Console.WriteLine("Withdraw cash option is still under construction");
            Console.SetCursorPosition(13, 3);
            Console.WriteLine(">>> PRESS ANY KEY TO EXIT <<<");
            Console.ReadKey();
        }
    }
}