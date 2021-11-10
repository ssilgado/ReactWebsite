using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactWebsite.DataAccess.Entities;

namespace ReactWebsite.DataAccess.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasIndex(e => e.ProductCode, "UQ__Product__2F4E024F6A1E1684")
                .IsUnique();

            builder.Property(e => e.AnnualFee).HasColumnType("decimal(18, 4)");

            builder.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.PricePerHour).HasColumnType("decimal(18, 4)");

            builder.Property(e => e.PricePerUnit).HasColumnType("decimal(18, 4)");

            builder.Property(e => e.ProductCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.ServiceFee).HasColumnType("decimal(18, 4)");

            builder.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.HasOne(d => d.Consultant)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.ConsultantId)
                .HasConstraintName("fkProductOnPersonPersonId");
        }
    }
}