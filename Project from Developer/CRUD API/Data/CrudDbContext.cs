using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Data
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.Employee> Employees { get; set; }
    }
}
