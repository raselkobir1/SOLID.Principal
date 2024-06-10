using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal.Example3
{
    public class InvoiceForRefund : BaseInvoice
    {
        public InvoiceForRefund(decimal amount) : base(amount)
        {
        }

        public override decimal CalculateInvoiceAmount()
        {
            decimal cancelAmount = Amount - 20;
            return cancelAmount;
        }
    }
}
