using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Dbcontext
{
    public class UserDBContext :DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            :base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Projects> Projs { get; set; }
        public DbSet<ResumeLink> ResLink { get; set; }
    }
}
