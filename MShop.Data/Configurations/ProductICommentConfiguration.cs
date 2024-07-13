namespace MShop.Data.Configurations
{
    public class ProductICommentConfiguration : IEntityTypeConfiguration<ProductComment>
    {
        public void Configure(EntityTypeBuilder<ProductComment> builder)
        {
            builder.ToTable("ProductComments");//Table Name

            builder.HasKey(p => p.ProductCommentId);//Key


            builder.Property(p => p.Comment)
                   .HasMaxLength(500);


            builder.Property(p => p.CommenterName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(p => p.CommenterEmail)
                   .IsRequired()
                   .HasMaxLength(200);


            builder.HasOne(p => p.Product)
                   .WithMany(p => p.ProductComments)
                   .HasForeignKey(p => p.ProductId);
        }
    }
}
