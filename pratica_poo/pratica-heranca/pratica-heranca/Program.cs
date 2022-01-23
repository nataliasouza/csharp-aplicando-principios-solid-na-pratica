using System;
using System.Globalization;

namespace pratica_heranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Holder = "Natt Souza";
            savingsAccount.Number = 31900;
            savingsAccount.Balance = 500.000;
            savingsAccount.GetBalance();

            Console.WriteLine($"Titular: { savingsAccount.Holder}");
            Console.WriteLine($"Número Conta: {savingsAccount.Number}");
            Console.WriteLine("Saldo:" + savingsAccount.Balance.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
