// Bank.cs
using System;
using System.Collections.Generic;

public class Bank
{
    private List<BankAccount> _accounts = new List<BankAccount>();

    public void AddAccount(BankAccount account)
    {
        _accounts.Add(account);
        Console.WriteLine($"Account {account.AccountNumber} added.");
    }

    public void PerformAccountOperations()
    {
        foreach (var account in _accounts)
        {
            account.GetAccountInfo();
            account.CalculateInterest();
            account.Withdraw(100); // Test withdraw operation
            account.GetAccountInfo();
        }
    }
}
