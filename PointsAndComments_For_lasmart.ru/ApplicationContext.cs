using Microsoft.EntityFrameworkCore;

namespace PointsAndComments_For_lasmart.ru
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options) { }

        public DbSet<Models.Point> Points { get; set; }
        public DbSet<Models.Comment> Comments { get; set; }
    }
}
