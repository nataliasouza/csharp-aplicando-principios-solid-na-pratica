using System;

namespace pratica_heranca
{
    //Classe ContaPoupanca
    public class SavingsAccount : Account
    {
        //Prop JurosMensais
        public int MonthlyInterest { get; set; }

        public override void GetBalance()
        {
            Console.WriteLine("Testando metódo sobrescrito: Saldo 1000,00\n");
        }
    }   
}
