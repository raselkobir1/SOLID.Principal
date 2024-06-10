using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
