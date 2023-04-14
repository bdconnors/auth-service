
using System.Data.Entity;
using System.Reflection.Emit;
using Auth.Data.Models;
using Microsoft.Extensions.Configuration;

namespace Auth.Data
{
    public class Context : DbContext
    {
       public DbSet<Org> Orgs { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Site> Sites { get; set; }
        public Context(IConfiguration configuration) : base(configuration.GetConnectionString("Auth"))
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>().HasMany(role => role.Permissions);
            modelBuilder.Entity<Role>().HasMany(role => role.Sites);
            modelBuilder.Entity<Role>().HasMany(role => role.Users);
  

            modelBuilder.Entity<Org>().HasMany(org => org.Sites);

            modelBuilder.Entity<Site>().HasRequired(site => site.Org);
            modelBuilder.Entity<Site>().HasMany(site => site.Roles);
            modelBuilder.Entity<Site>().HasMany(site => site.Users);


            modelBuilder.Entity<User>().HasMany(user => user.Sites);
            modelBuilder.Entity<User>().HasMany(user => user.Roles);
        
        }
    }
}
