// SavingsAccount.cs
using System;

public class SavingsAccount : BankAccount
{
    private decimal _interestRate;

    public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
        : base(accountNumber, initialBalance)
    {
        _interestRate = interestRate;
    }

    public override void CalculateInterest()
    {
        decimal interest = Balance * _interestRate;
        Deposit(interest); // Add interest to balance
        Console.WriteLine($"Interest of {interest} applied to Savings Account {AccountNumber}.");
    }
}
