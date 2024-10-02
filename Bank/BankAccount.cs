// BankAccount.cs
using System;

public abstract class BankAccount
{
    public string AccountNumber { get; protected set; }
    public decimal Balance { get; protected set; }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount} to {AccountNumber}. New Balance: {Balance}");
    }

    public virtual void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount} from {AccountNumber}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public abstract void CalculateInterest();

    public virtual void GetAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
    }
}
