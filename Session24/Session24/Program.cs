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
            if (amount < 0)
            {
                throw new InvalidOperationException("Cannot withdraw negative amount");
            }

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
            if (amount < 0)
            {
                throw new InvalidOperationException("Cannot deposit negative amount");
            }

            Balance += amount;
        }

        public void TransferTo(Account toAccount, int amount)
        {
            if (toAccount == null)
            {
                throw new InvalidOperationException("Cannot transfer to null account");
            }

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

        public void ApplyInterest(int v)
        {
            Balance = Balance + (int) (Balance * (v / 100.0));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
