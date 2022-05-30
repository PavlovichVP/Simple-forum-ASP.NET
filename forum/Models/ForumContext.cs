using Microsoft.EntityFrameworkCore;

namespace forum.Models
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions<ForumContext> options) : base(options)
        { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
