namespace OpenClosePrincipal.Example3
{
    public class InvoiceForCancel : BaseInvoice
    {
        public InvoiceForCancel(decimal amount) : base(amount)
        {
        }

        public override decimal CalculateInvoiceAmount() 
        {
            decimal cancelAmount = Amount * 5; 
            return cancelAmount;
        }
    }
}
