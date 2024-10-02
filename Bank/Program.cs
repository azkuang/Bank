// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create bank accounts
        SavingsAccount savings = new SavingsAccount("S001", 1000, 0.05m);
        CurrentAccount current = new CurrentAccount("C001", 500, 200);

        // Bank management
        Bank bank = new Bank();
        bank.AddAccount(savings);
        bank.AddAccount(current);

        // Perform operations
        bank.PerformAccountOperations();
    }
}
