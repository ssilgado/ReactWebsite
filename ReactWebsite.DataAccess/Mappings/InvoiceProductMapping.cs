using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactWebsite.DataAccess.Entities;

namespace ReactWebsite.DataAccess.Mappings
{
    public class InvoiceProductMapping : IEntityTypeConfiguration<InvoiceProduct>
    {
        public void Configure(EntityTypeBuilder<InvoiceProduct> builder)
        {
            builder.ToTable("InvoiceProduct");

            builder.HasIndex(e => new { e.InvoiceId, e.ProductId }, "uqInvoiceIdOnProductId")
                .IsUnique();

            builder.Property(e => e.BillableHours).HasColumnType("decimal(18, 4)");

            builder.Property(e => e.EndDate).HasColumnType("datetime");

            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.HasOne(d => d.Invoice)
                .WithMany(p => p.InvoiceProducts)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("fkInvoiceProductOnInvoiceInvoiceId");

            builder.HasOne(d => d.Product)
                .WithMany(p => p.InvoiceProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fkInvoiceProductOnProductProductId");
        }
    }
}