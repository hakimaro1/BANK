using System;
using System.Collections;

class CreateAccount
{
	static void Main()
	{
		Console.WriteLine("Sid''s Account");
		long sidsAccNo = Bank.CreateAccount();
		BankAccount sids = Bank.GetAccount(sidsAccNo);
		TestDeposit(sids);
		TestWithdraw(sids);
		Write(sids);
		if (Bank.CloseAccount(sidsAccNo))
			Console.WriteLine("Account closed");
		else
			Console.WriteLine("Something went wrong closing the account");
	}

	static void TestDeposit(BankAccount acc)
	{
		acc.Deposit(100);
		acc.Deposit(75);
	}

	static void TestWithdraw(BankAccount acc)
	{
		acc.Withdraw(50);
		acc.Withdraw(10);
		acc.Withdraw(10);
	}

	static void Write(BankAccount acc)
	{
		Console.WriteLine("Account number is {0}", acc.Number());
		Console.WriteLine("Account balance is {0}", acc.Balance());
		Console.WriteLine("Account type is {0}", acc.Type());
		Console.WriteLine("Transactions:");
		foreach (BankTransaction tran in acc.Transactions())
		{
			Console.WriteLine("  Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
		}
	}
}

