
using System.Data.Entity;
using System.Reflection.Emit;
using Auth.Data.Models;
using Microsoft.Extensions.Configuration;

namespace Auth.Data
{

    public class AuthorizationDbContext : DbContext
    {
        public AuthorizationDbContext(IConfiguration configuration) : base(configuration.GetConnectionString("Auth")) 
        { 
        }

        public DbSet<Org> Orgs { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Org>().HasMany(org => org.Sites);

            modelBuilder.Entity<Site>().HasMany(site => site.UserSites);
            modelBuilder.Entity<Site>().HasRequired(site => site.Org);

            modelBuilder.Entity<User>().HasMany(user => user.UserSites);
        }
    }
}
