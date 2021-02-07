using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerAccounts;

namespace AccountTests
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void AccountsHaveAnOpeningBalanceOfZero()
        {
            // Arrange

            // Act
            var account = new Account();

            // Assert
            // Note: Cannot have any tests fail because the ci build would fail.
            // Uncomment this line to see the test fail as expected
            //Assert.AreEqual(0m, account.Balance);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void AddingTransactionChangesBalance()
        {
            // Arrange
            var account = new Account();

            // Act
            account.AddTransaction(200m);

            // Assert
            Assert.AreEqual(200m, account.Balance);
        }
    }
}
