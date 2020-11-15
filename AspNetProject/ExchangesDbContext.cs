using Microsoft.EntityFrameworkCore;


namespace AspNetProject
{
    public class ExchangesDbContext : DbContext
    {
        public ExchangesDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<ItemEntity> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // fluent configuration ...
        }
    }
}