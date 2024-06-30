using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MShop.Data.Entities;

namespace MShop.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");//Table Name

            builder.HasKey(c => c.CategoryId);//Key

            builder.Property(c => c.CategoryName) //property ile ilgili ayarlar yapılır
                   .IsRequired()
                   .HasMaxLength(100);

            //builder.Property(x => x.Order)
            //        .IsRequired()
            //        .HasColumnName("_order");

        }
    }
}

//IEntityTypeConfiguration : ilgili Entity için Temel configurasyonları yapmak için kullanılır 