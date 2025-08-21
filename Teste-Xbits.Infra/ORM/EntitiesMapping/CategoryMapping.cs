using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste_Xbits.Domain.Entities;
using Teste_Xbits.Infra.ORM.EntitiesMapping.Base;


namespace Teste_Xbits.Infra.ORM.EntitiesMapping;

public sealed class CategoryMapping : BaseMapping, IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category), Schema);

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnType("bigint")
            .HasColumnName("id")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Name)
            .HasColumnType("varchar(80)")
            .HasColumnName("name")
            .IsRequired();

        builder.HasIndex(c => c.Name)
            .IsUnique();

        builder.Property(c => c.CreatedAt)
            .HasColumnType("datetime")
            .HasColumnName("created_at")
            .IsRequired();

        builder.Property(c => c.UpdatedAt)
            .HasColumnType("datetime")
            .HasColumnName("updated_at")
            .IsRequired();

        builder.HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}