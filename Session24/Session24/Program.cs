using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session24
{
    public class Account
    {
        public string Name;
        public int Balance;

        public void Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Balance too low to withdraw");
            }
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public void TransferTo(Account toAccount, int amount)
        {
            if (Balance >= amount)
            {
                Withdraw(amount);
                toAccount.Deposit(amount);
            }
            else
            {
                throw new InvalidOperationException("Balance too low to transfer");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
