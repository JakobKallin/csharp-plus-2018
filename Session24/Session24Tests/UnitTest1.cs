using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Session24;

namespace Session24Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void TestDeposit()
        {
            Account account = new Account
            {
                Name = "Test",
                Balance = 0
            };
            account.Deposit(500);
            Assert.AreEqual(account.Balance, 500);
        }

        [TestMethod]
        public void TestWithdrawal()
        {
            Account account = new Account
            {
                Name = "Test",
                Balance = 500
            };
            account.Withdraw(200);
            Assert.AreEqual(account.Balance, 300);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestNegativeDeposit()
        {
            Account account = new Account
            {
                Name = "Test",
                Balance = 0
            };
            account.Deposit(-500);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestNegativeWithdrawal()
        {
            Account account = new Account
            {
                Name = "Test",
                Balance = 0
            };
            account.Withdraw(-500);
        }

        [TestMethod]
        public void TestTransfer()
        {
            Account from = new Account
            {
                Name = "From",
                Balance = 500
            };
            Account to = new Account
            {
                Name = "To",
                Balance = 0
            };
            from.TransferTo(to, 200);
            Assert.AreEqual(from.Balance, 300);
            Assert.AreEqual(to.Balance, 200);
        }
    }
}
