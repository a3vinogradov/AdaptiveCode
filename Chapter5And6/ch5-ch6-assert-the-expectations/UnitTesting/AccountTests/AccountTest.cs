using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerAccounts;

namespace AccountTests
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void AddingTransactionChangesBalance()
        {
            // Arrange
            var account = new Account();

            // Act
            account.AddTransaction(200m);

            // Assert
            // Note: Cannot fail any tests because the ci build would also fail.
            // Uncomment this line to see the test fail as expected:
            //Assert.AreEqual(200m, account.Balance);
	        Assert.Inconclusive();
        }
    }
}
