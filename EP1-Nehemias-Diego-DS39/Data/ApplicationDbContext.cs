using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EP1_nehemias_diego_ds39.Models;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;

namespace EP1_Nehemias_Diego_DS39.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EP1_nehemias_diego_ds39.Models.Category> Categories { get; set; }
        public DbSet<EP1_nehemias_diego_ds39.Models.Supplier> Suppliers { get; set; }
        public DbSet<EP1_nehemias_diego_ds39.Models.Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUserLogin<string>>()
                .HasKey(login => login.UserId);

            builder.Entity<Category>().ToTable("Category");
            builder.Entity<Supplier>().ToTable("Supplier");
            builder.Entity<Product>().ToTable("Product");
        }
    }
}
