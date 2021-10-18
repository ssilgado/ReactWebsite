using System;
using System.Collections.Generic;

#nullable disable

namespace ReactWebsite.DataAccess.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int? PersonId { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
