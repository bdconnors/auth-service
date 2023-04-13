
using System.Data.Entity;
using System.Diagnostics;
using Auth.Data.Models;
using Microsoft.Configuration;

namespace Auth.Data
{
    public class Context : DbContext
    {
       public DbSet<Org> Orgs { get; set; }
        //public DbSet<Permission> Permissions { get; set; }
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Site> Sites { get; set; }
        //public DbSet<UserSiteRole> SiteRoles { get; set; }
        public Context(IConfiguration configuration) : base(configuration.GetConnectionString("Auth"))
        {
        
       }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Org>().HasMany(org => org.Sites);
        }
    }
}
