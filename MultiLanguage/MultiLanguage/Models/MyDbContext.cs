using Microsoft.EntityFrameworkCore;

namespace MultiLanguage.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
