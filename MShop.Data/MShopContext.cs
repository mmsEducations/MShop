﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        //...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Entity Configuration class added 
            modelBuilder.AddCustomEntityConfigurations();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=MShop;Trusted_Connection=True;Encrypt=False;");
        }


    }
}
