using EntityFramworkCoreCompleteDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramworkCoreCompleteDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
