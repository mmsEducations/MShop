namespace MShop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.ProductId);//Key

            builder.Property(p => p.ProductName)
                   .HasMaxLength(500)
                   .IsRequired();

            builder.Property(p => p.MainDescription)
                   .HasMaxLength(5000)
                   .IsRequired();


            builder.Property(p => p.Price)
                   .HasColumnType("decimal(18,2)");

            builder.Property(p => p.MarketPrice)
                   .HasColumnType("decimal(18,2)");

            //Relationships
            builder.HasMany(p => p.ProductImages)
                   .WithOne(p => p.Product)
                   .HasForeignKey(p => p.ProductId);


            builder.HasMany(p => p.ProductComments)
                   .WithOne(p => p.Product)
                   .HasForeignKey(p => p.ProductId);


            builder.HasOne(p => p.Category)
               .WithMany(p => p.Products)
               .HasForeignKey(p => p.CategoryId);

        }
    }
}
