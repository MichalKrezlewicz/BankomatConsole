using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatConsole
{
    namespace BankomatConsole
    {
        public class ConsoleMenu
        {
            private int selectedOption;

            public void Run()
            {
                Console.CursorVisible = false;
                ConsoleKey key;

                do
                {
                    DisplayGreeting();
                    DisplayInstruction();
                    DisplayMenu();

                    key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.UpArrow && selectedOption > 0)
                        selectedOption--;
                    else if (key == ConsoleKey.DownArrow && selectedOption < 2)
                        selectedOption++;
                    else if (key == ConsoleKey.Enter)
                        ExecuteSelectedOption();

                } while (key != ConsoleKey.Escape);
            }

            private void DisplayGreeting()
            {
                string greeting = "Hello User";
                Console.WriteLine(greeting);
                Console.WriteLine();
            }

            private void DisplayInstruction()
            {
                string instruction = "Choose option";
                Console.WriteLine(instruction);
                Console.WriteLine();
            }

            private void DisplayMenu()
            {
                string[] options = { "Withdraw cash", "Deposit cash", "Check balance" };

                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {options[i]}");
                }

                Console.WriteLine();
            }

            private void ExecuteSelectedOption()
            {
                switch (selectedOption)
                {
                    case 0:
                        Console.WriteLine("Wybrano opcję 1");
                        break;
                    case 1:
                        Console.WriteLine("Wybrano opcję 2");
                        break;
                    case 2:
                        Console.WriteLine("Wybrano opcję 3");
                        break;
                }

                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey(true);
            }
        }
    }
}
