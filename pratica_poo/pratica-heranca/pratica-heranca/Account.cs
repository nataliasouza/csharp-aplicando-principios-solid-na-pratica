using System;

namespace pratica_heranca
{
    public class Account
    {
        public int Number { get; set; }
        public double Balance { get; set; }
        public string Holder { get; set; }

        public Account()
        {}

        public virtual void GetBalance()
        {
            Console.WriteLine("Saldo 99,00");
        }
    }
}
