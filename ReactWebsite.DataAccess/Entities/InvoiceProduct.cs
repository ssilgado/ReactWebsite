using System;
using System.Collections.Generic;

#nullable disable

namespace ReactWebsite.DataAccess.Entities
{
    public partial class InvoiceProduct
    {
        public int InvoiceProductId { get; set; }
        public int? EquipmentUnits { get; set; }
        public decimal? BillableHours { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? InvoiceId { get; set; }
        public int? ProductId { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
