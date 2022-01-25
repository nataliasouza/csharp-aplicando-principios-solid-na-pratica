namespace uml_heranca
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
                
        public double Withdraw(double withdrawalAmount)
        {
            return Balance - withdrawalAmount;
        }
        public double Deposit(double depositAmount)
        {
            return Balance + depositAmount;
        }
    }
}
