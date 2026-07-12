using Catalog.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Shared.Infra
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
