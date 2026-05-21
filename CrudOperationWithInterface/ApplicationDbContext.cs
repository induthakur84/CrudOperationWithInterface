using CrudOperationWithInterface.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationWithInterface
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
