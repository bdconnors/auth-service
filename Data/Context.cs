
using System.Data.Entity;
using System.Diagnostics;
using Auth.Data.Models;

namespace Auth.Data
{
    public class Context : DbContext
    {
       public DbSet<Org> Orgs { get; set; }
       public DbSet<Permission> Permissions { get; set; }
       public DbSet<Role> Roles { get; set; }
       public DbSet<User> Users { get; set; }
       public DbSet<Site> Sites { get; set; }
       public DbSet<UserSiteRole> SiteRoles { get; set; }
       public Context() : base("Server=DL-44\\SQLEXPRESS;Database=rbac;User Id=sa;Password=Body585Armor@#;") 
       {
        
       }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Org>().HasMany(org => org.Sites);
            modelBuilder.Entity<Site>().HasRequired(site => site.Roles);
        }
    }
}
