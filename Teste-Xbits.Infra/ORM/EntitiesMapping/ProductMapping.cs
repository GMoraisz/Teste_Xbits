using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste_Xbits.Domain.Entities;
using Teste_Xbits.Infra.ORM.EntitiesMapping.Base;


namespace Teste_Xbits.Infra.ORM.EntitiesMapping;

public sealed class ProductMapping : BaseMapping, IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(nameof(Product), Schema);

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasColumnType("bigint")
            .HasColumnName("id")
            .ValueGeneratedOnAdd();

        builder.Property(p => p.Name)
            .HasColumnType("varchar(100)")
            .HasColumnName("name")
            .IsRequired();

        builder.Property(p => p.Price)
            .HasColumnType("decimal(6,2)")
            .HasColumnName("price")
            .IsRequired();

        builder.Property(p => p.CategoryId)
            .HasColumnType("bigint")
            .HasColumnName("category_id")
            .IsRequired();

        builder.Property(p => p.CreatedAt)
            .HasColumnType("datetime")
            .HasColumnName("created_at")
            .IsRequired();

        builder.Property(p => p.UpdatedAt)
            .HasColumnType("datetime")
            .HasColumnName("updated_at")
            .IsRequired();

        builder.HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);
    }
}