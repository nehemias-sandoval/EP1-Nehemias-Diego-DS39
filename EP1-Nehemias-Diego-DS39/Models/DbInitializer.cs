using EP1_Nehemias_Diego_DS39.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net;

namespace EP1_nehemias_diego_ds39.Models
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
            {
                var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

                if (userManager.FindByEmailAsync("admin@example.com").Result == null)
                {
                    var user = new IdentityUser
                    {
                        UserName = "user@example.com",
                        Email = "user@example.com",
                        EmailConfirmed = true,
                    };

                    var result = userManager.CreateAsync(user, "Admin123!").Result;
                    serviceProvider.GetRequiredService<ApplicationDbContext>().SaveChanges();
                }

                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Categories.AddRange(
                    new Category
                    {
                        CategoryName = "Bebidas",
                        Description = "Cualquier líquido que se ingiere",
                        PictureUrl = "https://www.finedininglovers.com/es/sites/g/files/xknfdk1706/files/2022-05/bebidas-refrescantes-sin-alcohol%C2%A9iStock.jpg",
                    }
                );

                context.SaveChanges();

                context.Suppliers.AddRange(
                    new Supplier
                    {
                        CompanyName = "Coca Cola",
                        ContactName = "Nehemias Sandoval",
                        ContactTitle = "Ingeniero",
                        Address = "San Salvador",
                        City = "San Salvador",
                        Region = "SV",
                        PostalCode = "115",
                        Country = "El Salvador",
                        Phone = "7588-9944",
                        Fax = "2555-4466",
                        HomePage = "https://www.coca-cola.com/es/es"
                    }
                );

                context.SaveChanges();

                context.Products.AddRange(
                    new Product
                    {
                        ProductName = "Sprite",
                        SupplierId = 1,
                        CategoryId = 1,
                        QuantityPerUnit = 50,
                        UnitPrice = 15.5,
                        UnitsInStock = 50,
                        UnitsOnOrder = 50,
                        ReorderLevel = 1,
                        Discontinued = false,
                    },
                    new Product
                    {
                        ProductName = "Tropical",
                        SupplierId = 1,
                        CategoryId = 1,
                        QuantityPerUnit = 30,
                        UnitPrice = 20.5,
                        UnitsInStock = 50,
                        UnitsOnOrder = 30,
                        ReorderLevel = 1,
                        Discontinued = false,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
