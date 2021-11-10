using System;
using System.Collections.Generic;

#nullable disable

namespace ReactWebsite.DataAccess.Entities
{
    public partial class Product
    {
        public Product()
        {
            InvoiceProducts = new HashSet<InvoiceProduct>();
        }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal? PricePerUnit { get; set; }
        public decimal? PricePerHour { get; set; }
        public decimal? AnnualFee { get; set; }
        public decimal? ServiceFee { get; set; }
        public int? ConsultantId { get; set; }

        public virtual Person Consultant { get; set; }
        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; }
    }
}
