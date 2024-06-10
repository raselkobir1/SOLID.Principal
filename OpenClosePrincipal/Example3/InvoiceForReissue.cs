using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal.Example3
{
    public class InvoiceForReissue : BaseInvoice
    {
        public InvoiceForReissue(decimal amount) : base(amount)
        {
        }

        public override decimal CalculateInvoiceAmount() 
        {
            decimal reissueAmount = Amount * 10; 
            return reissueAmount;
        }
    }
}
