// CurrentAccount.cs
using System;

public class CurrentAccount : BankAccount
{
    private decimal _overdraftLimit;

    public CurrentAccount(string accountNumber, decimal initialBalance, decimal overdraftLimit)
        : base(accountNumber, initialBalance)
    {
        _overdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance + _overdraftLimit >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount} from {AccountNumber} (including overdraft). New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded.");
        }
    }

    public override void CalculateInterest()
    {
        // No interest calculation for Current Accounts
        Console.WriteLine($"Current Account {AccountNumber} does not earn interest.");
    }
}
