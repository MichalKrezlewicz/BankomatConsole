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
        public static void withdrawMoneyView(Account programAccount)
        {
            Console.SetCursorPosition(4, 1);
            Console.WriteLine("Please write the amount of money to withdraw: ");
            double amount = Double.Parse(Console.ReadLine());
            if(!Operations.IsWithdrawPossible(programAccount, amount))
            {
                Console.WriteLine("There is not enough money on your account.");
                Console.SetCursorPosition(13, 5);
                Console.WriteLine(">>> PRESS ANY KEY TO EXIT <<<");
                Console.ReadKey();
                return;
            }

            // zrobic jeszcze petle podoki klient nie wprowdzi wlasciwej kwoty, zapytac go czy chce wprowadzic inna kwote (while true) + break

            Operations.DecreaseBalance(programAccount, amount);

            Console.SetCursorPosition(13, 3);
            Console.WriteLine(">>> PRESS ANY KEY TO EXIT <<<");
            Console.ReadKey();
        }
    }
}

//dorobic try parse i string NotNullOrWhiteSpace na double wpisywany przez uzytkownika 

//sprawdzic czy amount nie jest wieksze niz obecny balance (opcja: nowa metoda checkBalance w Operations, za pomoca bool)

//wprowadzic limity na wypłaty