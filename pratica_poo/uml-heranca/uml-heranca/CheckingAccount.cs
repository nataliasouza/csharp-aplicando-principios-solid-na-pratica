namespace uml_heranca
{
    public class CheckingAccount : Account
    {
        
        public double Limit { get; set; }       
      
        public double InterestDiscount(double discountAmount)
        {
            return Balance - discountAmount;
        }
    }
}
