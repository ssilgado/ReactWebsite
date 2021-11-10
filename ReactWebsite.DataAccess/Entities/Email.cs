using System;
using System.Collections.Generic;

#nullable disable

namespace ReactWebsite.DataAccess.Entities
{
    public partial class Email
    {
        public int EmailId { get; set; }
        public int? PersonId { get; set; }
        public string EmailAddress { get; set; }

        public virtual Person Person { get; set; }
    }
}
