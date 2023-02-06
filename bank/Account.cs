using System;
namespace bank
{
	public class Account
	{
		public string AccountHolder { get; set; }
		// nooit double voor geld
		public double Balance { get; set; }


		public Account(string accountHolder, double balance)
		{
			AccountHolder = accountHolder;
			Balance = balance;
		}

		public void Deposit(double amount)
		{
			Balance = Balance + amount;
		}

		public void Withdraw(double amount)
		{
			Balance = Balance - amount;
		}
	}
}

