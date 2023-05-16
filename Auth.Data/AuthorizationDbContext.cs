

using System.Reflection.Emit;
using System.Reflection.Metadata;
using Auth.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EF6 = System.Data.Entity; // use EF6.DbContext for the EF6 version

namespace Auth.Data
{

    public class AuthorizationDbContext : EF6.DbContext
    {
        public AuthorizationDbContext(IConfiguration configuration) : base(configuration.GetConnectionString("Auth")) 
        { 
        }
        //used for unit tests
        public AuthorizationDbContext(string connString) : base(connString)
        {
        }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(EF6.DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tenant>().HasMany(t => t.Users);
            modelBuilder.Entity<Tenant>().HasMany(t => t.Roles);
            modelBuilder.Entity<Tenant>().HasMany(t => t.Permissions);

            modelBuilder.Entity<User>().HasMany(u => u.UserRoles);
            modelBuilder.Entity<Role>().HasMany(u => u.RolePermissions);

            modelBuilder.Entity<Role>().HasMany(u => u.UserRoles);

        }
    }
}
