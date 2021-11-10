using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactWebsite.DataAccess.Entities;

namespace ReactWebsite.DataAccess.Mappings
{
    public class EmailMapping : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("Email");

            builder.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("emailAddress");

            builder.HasOne(d => d.Person)
                .WithMany(p => p.Emails)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("fkEmailOnPersonPersonId");
        }
    }
}