using Microsoft.EntityFrameworkCore;
using JwtAuthDotNet9.Entities;

namespace JwtAuthDotNet9.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; } = null!;

        // public UserDbContext(DbContextOptions<UserDbContext> options)
        // : base(options) { }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<User>().ToTable("Users");
        // }

    }
}
