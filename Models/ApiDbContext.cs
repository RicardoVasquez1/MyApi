using Microsoft.EntityFrameworkCore;

namespace MyApi.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
