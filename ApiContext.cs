using Microsoft.EntityFrameworkCore;

namespace TesteApi
{
    public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
