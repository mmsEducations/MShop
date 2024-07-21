namespace MShop.Data.Extensions
{
    public static class IdentityModelBuilderExtensions
    {
        public static void ConfigureIdentityTables(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(login => new { login.LoginProvider, login.ProviderKey });

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasKey(iur => new { iur.UserId, iur.RoleId });

            // Define composite primary key for IdentityUserToken<string>
            modelBuilder.Entity<IdentityUserToken<string>>()
                .HasKey(token => new { token.UserId, token.LoginProvider, token.Name });
        }

    }
}
