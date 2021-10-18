using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactWebsite.DataAccess.Entities;

namespace ReactWebsite.DataAccess.Mappings
{
    public class InvoiceMapping : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice");

            builder.Property(e => e.InvoiceCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(d => d.Customer)
                .WithMany(p => p.Invoices)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("fkInvoiceOnCustomerCustomerId");

            builder.HasOne(d => d.Person)
                .WithMany(p => p.Invoices)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("fkInvoiceOnPersonPersonId");
        }
    }
}