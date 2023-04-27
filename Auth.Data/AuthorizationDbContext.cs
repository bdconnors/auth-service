

using System.Reflection.Emit;
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
        public DbSet<Org> Orgs { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSite> UserSites { get; set; }

        protected override void OnModelCreating(EF6.DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserSite>().HasRequired(userSite => userSite.Site);
            modelBuilder.Entity<UserSite>().HasRequired(userSite => userSite.User);

            modelBuilder.Entity<Org>().HasMany(org => org.Sites);

            modelBuilder.Entity<Site>().HasMany(site => site.UserSites);
            modelBuilder.Entity<Site>().HasRequired(site => site.Org);

            modelBuilder.Entity<User>().HasMany(user => user.UserSites);
        }
    }
}
