using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankomatConsole.Views;
using System.Threading.Tasks;

namespace BankomatConsole.Menu
{
    static class AdvancedMenu
    {
        static string[] menuOptions = { "Withdraw cash (1)", "Deposit cash (2)", "Check balance (3)", "Exit (4)" };
        static int activeOption = 0;
        private static Account _programAccount;

        public static void StartMenu(Account programAccount)
        {
            Console.Title = "YourATM by Michał Krężlewicz";
            Console.CursorVisible = false;

            _programAccount = programAccount;

            while (true)
            {
                ShowMenu();
                ChooseOption();
                RunOption();
            }
        }

        static void ShowMenu()
        {
            Console.Clear();
            AsciiArt.DisplayAscii();
            Console.Write("".PadLeft(8));
            Console.WriteLine("Use arrow keys or number keys.");
            Console.WriteLine();
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == activeOption)
                {
                    Console.Write("".PadLeft(8));
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(menuOptions[i]);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write("".PadLeft(8));
                    Console.WriteLine(menuOptions[i]);
                }
            }
        }

        static void ChooseOption()
        {
            do
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    activeOption = (activeOption > 0) ? activeOption - 1 : menuOptions.Length - 1;
                    ShowMenu();
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    activeOption = (activeOption + 1) % menuOptions.Length;
                    ShowMenu();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    activeOption = menuOptions.Length - 1;
                    ShowMenu();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (key.KeyChar >= '1' && key.KeyChar <= '4')
                {
                    int optionIndex = key.KeyChar - '1';
                    if (optionIndex < menuOptions.Length)
                    {
                        activeOption = optionIndex;
                        ShowMenu();
                        break;
                    }
                }
            }
            while (true);
        }



        static void RunOption()
        {
            switch (activeOption)
            {
                case 0: Console.Clear(); WithdrawMoneyView.withdrawMoneyView(_programAccount); break;
                case 1: Console.Clear(); DepositCashView.depositCashView(_programAccount); break;
                case 2: Console.Clear(); CheckBalanceView.checkBalanceView(_programAccount); break;
                case 3: Environment.Exit(0); break;
            }
        }
    }
}
