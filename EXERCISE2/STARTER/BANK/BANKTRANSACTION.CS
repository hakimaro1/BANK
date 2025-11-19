using System;

namespace Banking
{
    public class BankTransaction
    {
        private decimal amount;
        private DateTime when;

        internal BankTransaction(decimal amount)
        {
            this.amount = amount;
            this.when = DateTime.Now;
        }

        public decimal Amount()
        {
            return amount;
        }

        public DateTime When()
        {
            return when;
        }
    }
}
