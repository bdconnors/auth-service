
using System.Data.Entity;
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
        public DbSet<SiteRole> SiteRoles { get; set; }
        public Context(IConfiguration configuration) : base(configuration.GetConnectionString("Auth"))
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Org>().HasMany(org => org.Sites);

            modelBuilder.Entity<Site>().HasRequired(site => site.Org);
            modelBuilder.Entity<Site>().HasMany(site => site.Roles);

            modelBuilder.Entity<Role>().HasMany(role => role.Permissions);

            modelBuilder.Entity<SiteRole>().HasRequired(siteRole => siteRole.Site);
            modelBuilder.Entity<SiteRole>().HasRequired(siteRole => siteRole.Role);

            modelBuilder.Entity<User>().HasRequired(user => user.Org);
            modelBuilder.Entity<User>().HasMany(user => user.SiteRoles);

        }
    }
}
