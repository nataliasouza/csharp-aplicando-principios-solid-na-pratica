using System;

namespace uml_heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Balance = savingsAccount.Deposit(500);
            savingsAccount.Balance = savingsAccount.Withdraw(100);

            Console.WriteLine($"Poupança: {savingsAccount.InterestCredit(5)}");

            CheckingAccount checkingAccount = new CheckingAccount();
            checkingAccount.Balance = checkingAccount.Deposit(500);
            checkingAccount.Balance = checkingAccount.Withdraw(100);

            Console.WriteLine($"Poupança: {checkingAccount.InterestDiscount(10)}");
        }
    }
}
