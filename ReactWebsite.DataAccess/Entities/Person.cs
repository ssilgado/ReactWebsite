using System;
using System.Collections.Generic;

#nullable disable

namespace ReactWebsite.DataAccess.Entities
{
    public partial class Person
    {
        public Person()
        {
            Customers = new HashSet<Customer>();
            Emails = new HashSet<Email>();
            Invoices = new HashSet<Invoice>();
            Products = new HashSet<Product>();
        }

        public int PersonId { get; set; }
        public string PersonCode { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
