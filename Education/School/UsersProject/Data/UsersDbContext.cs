using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Data
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(@"Server=MARTO\SQLEXPRESS;Database=Users;Integrated Security=true;TrustServerCertificate=true;");
            }
        }

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<Log> Logs { get; set; } = null!;

        public DbSet<UserLog> UserLogs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserLog>().HasKey(ul => new { ul.UserId, ul.LogId });

            builder.Entity<User>()
                .HasMany(u => u.Logs)
                .WithOne(l => l.User)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Log>()
                .HasOne(u => u.User)
                .WithMany(l => l.Logs)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }
    }
}
