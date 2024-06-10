using System;

namespace OpenClosePrincipal.Example3
{
    public abstract class BaseInvoice
    {
        public BaseInvoice(decimal amount) 
        {
            Amount = amount;
        }
        public decimal Amount { get; set; }
        public abstract decimal CalculateInvoiceAmount(); 
    }
}
