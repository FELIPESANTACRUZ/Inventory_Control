using Microsoft.EntityFrameworkCore;
using Inventory_Control.Models;

namespace Inventory_Control.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options)
            : base(options)
        {   
        }

        public DbSet<Product> Products {get; set;} 

        public DbSet<Category> Categories {get; set;}
    }   
}
