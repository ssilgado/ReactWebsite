using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactWebsite.DataAccess.Entities;

namespace ReactWebsite.DataAccess.Mappings
{
    public class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");

            builder.HasIndex(e => e.PersonCode, "UQ__Person__7B5569EDB1E399B0")
                .IsUnique();

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.PersonCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(d => d.Address)
                .WithMany(p => p.People)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("fkPersonOnAddressAddressId");
        }
    }
}