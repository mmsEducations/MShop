
namespace MShop.Data
{
    public static class ModelBuilderExtensions
    {
        public static void AddCustomEntityConfigurations(this ModelBuilder modelBuilder)
        {
            //Entity Configuration class added 
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SliderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductICommentConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
        }
    }
}
