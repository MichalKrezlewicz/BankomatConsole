using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatConsole
{
    public class Account
    {
        public int AccountId { get; set; }
        private double accountBalance;

        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public Account(int accountId, double accountBalance)
        {
            AccountId = accountId;
            AccountBalance = 0.0;
        }

        //class BankAccount
        //{
        //    private double balance = 0;
        //    public void Deposit(double n) => balance = n;
        //    public void Withdraw(double n) => balance -= n;
        //    public double GetBalance() => balance;
        //}
    }
}
