using Microsoft.EntityFrameworkCore;
using MShop.Data.Configurations;
using MShop.Data.Entities;

namespace MShop.Data
{
    public class MShopContext : DbContext
    {
        //public MShopContext(DbContextOptions<MShopContext> options) : base(options)
        //{

        //}

        //DB Tables 

        public DbSet<Category> Categories { get; set; }
        //...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Entity Configuration class added 
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=MShop;Trusted_Connection=True;Encrypt=False;");
        }


    }
}
