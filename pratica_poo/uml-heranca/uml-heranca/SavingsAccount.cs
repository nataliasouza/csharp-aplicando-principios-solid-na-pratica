using System;

namespace uml_heranca
{
    public class SavingsAccount : Account
    {
        public DateTime BirthDate { get; set; }
        public double Income { get; set; }

        public double InterestCredit(double income)
        {
            return Balance + income;
        }

    }
}
