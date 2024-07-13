
namespace MShop.Data
{
    public class MShopContext : DbContext
    {

        //public MShopContext(DbContextOptions<MShopContext> options) : base(options)
        //{

        //}

        //DB Tables 

        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductComment> ProductComments { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        //...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Entity Configuration class added 
            modelBuilder.AddCustomEntityConfigurations();

            //Dummy data Created
            modelBuilder.CreateSeedData();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=MShop;Trusted_Connection=True;Encrypt=False;");
        }


    }
}
