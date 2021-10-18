using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactWebsite.DataAccess.Entities;

namespace ReactWebsite.DataAccess.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Zip)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(d => d.Country)
                .WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkAddressOnCountryCountryId");

            builder.HasOne(d => d.State)
                .WithMany(p => p.Addresses)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkAddressOnStateStateId");
        }
    }
}