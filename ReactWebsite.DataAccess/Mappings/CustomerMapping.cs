using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactWebsite.DataAccess.Entities;

namespace ReactWebsite.DataAccess.Mappings
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasIndex(e => e.CustomerCode, "UQ__Customer__066785210AE04B42")
                .IsUnique();

            builder.Property(e => e.CustomerCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.HasOne(d => d.Address)
                .WithMany(p => p.Customers)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("fkCustomerOnAddressAddressId");

            builder.HasOne(d => d.Person)
                .WithMany(p => p.Customers)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("fkCustomerOnPersonPersonId");
        }
    }
}