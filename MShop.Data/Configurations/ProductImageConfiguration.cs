using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MShop.Data.Entities;

namespace MShop.Data.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");//Table Name

            builder.HasKey(p => p.ProductImageId);//Key

            builder.Property(p => p.Image)
                   .IsRequired();

            builder.HasOne(p => p.Product)
                   .WithMany(p => p.ProductImages)
                   .HasForeignKey(p => p.ProductId);
        }
    }
}
