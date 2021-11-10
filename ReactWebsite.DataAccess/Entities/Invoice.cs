using System;
using System.Collections.Generic;

#nullable disable

namespace ReactWebsite.DataAccess.Entities
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceProducts = new HashSet<InvoiceProduct>();
        }

        public int InvoiceId { get; set; }
        public string InvoiceCode { get; set; }
        public int? CustomerId { get; set; }
        public int? PersonId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; }
    }
}
