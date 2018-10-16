using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session19Part3
{
    class Account
    {
        private int balance;
        public int Balance {
            get
            {
                return balance;
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > balance)
            {
                balance -= 100;
            }
            balance -= amount;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.Deposit(500);
            a.Withdraw(700);
            Console.WriteLine("Your current balance is: " + a.Balance);
        }
    }
}
