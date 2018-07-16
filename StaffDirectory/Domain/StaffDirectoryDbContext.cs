using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffDirectory.Domain
{
    public class StaffDirectoryDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }


        public StaffDirectoryDbContext(DbContextOptions<StaffDirectoryDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                         .HasMany(s => s.UserRoles)
                         .WithOne(s => s.User);

            modelBuilder.Entity<Role>()
                        .HasMany(s => s.RoleUsers)
                        .WithOne(s => s.Role);
        }
    }
}
