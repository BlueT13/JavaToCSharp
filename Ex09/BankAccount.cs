using System;

namespace Ex09
{
	internal class BankAccount
	{
		private double balance;

		public void PrintBankAccount()
		{
			BankAccount account1 = new BankAccount(50.00);
			BankAccount account2 = new BankAccount(-7.53);

			Console.Write("account1 balance: ${0:N2}\n", account1.GetBalalnce());
			Console.WriteLine("account2 balance: ${0:N2}\n", account2.GetBalalnce());

			double depositAmount;
			Console.Write("Enter deposit amount: ");
			depositAmount = Convert.ToDouble(Console.ReadLine());
			account1.Credit(depositAmount);
			Console.WriteLine("account1 balance: ${0:N2}\n", account1.GetBalalnce());

			Console.Write("Enter deposit amount: ");
			depositAmount = Convert.ToDouble(Console.ReadLine());
			account2.Credit(depositAmount);
			Console.WriteLine("account2 balance: ${0:N2}", account2.GetBalalnce());
		}

		public BankAccount() { }

		public BankAccount(double initialBalance)
		{
			if(initialBalance>0)
			{
				balance = initialBalance;
			}
		}

		public void Credit(double amount)
		{
			balance += amount;
		}

		public double GetBalalnce()
		{
			return balance;
		}
	}
}
