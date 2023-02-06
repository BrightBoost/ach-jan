using bank;

namespace bankTest;

[TestClass]
public class BankTest
{
    [TestMethod]
    public void WithdrawTest()
    {
        Account account = new Account("Ben", 100);
        account.Withdraw(5);
        Assert.AreEqual(account.Balance, 50);
    }

    [TestMethod]
    public void DepositTest()
    {
        Account account = new Account("Ben", 100);
        account.Deposit(5);
        Assert.AreEqual(account.Balance, 105);
    }
}
