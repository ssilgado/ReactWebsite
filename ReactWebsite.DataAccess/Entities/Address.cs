using System;
using System.Collections.Generic;

#nullable disable

namespace ReactWebsite.DataAccess.Entities
{
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
            People = new HashSet<Person>();
        }

        public int AddressId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Street { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
