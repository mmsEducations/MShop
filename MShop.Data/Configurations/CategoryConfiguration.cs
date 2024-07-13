
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
//Entity objelerinin karşılığı olarak Database de oluşacak tablonun adı,Enitity propertylerinin
//veri tiplerinin karşılığı ,Veri tiplerinin boyutu vb özetle Database de nasıl bir tablo oluşmasını istiyorsak 
//burda iligli entity için ayarlamalarını yaparız.