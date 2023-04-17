using Auth.Data.Models;
using System.Data.Entity;

namespace Auth.Data
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {

            Role admin = new Role() 
            { 
                Title = "ADMIN", 
                Description = "Create, Read, Update, and Delete Permissions", 
                Label = "Admin",
                Create = true,
                Read = true,
                Update = true,
                Delete = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            Role contributor = new Role()
            {
                Title = "CONTRIBUTOR",
                Description = "Create, Read, and Update Permissions",
                Label = "Data Contributor",
                Create = true,
                Read = true,
                Update = true,
                Delete = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            Role reader = new Role()
            {
                Title = "READER",
                Description = "Read Permission",
                Label = "Data Reader",
                Create = false,
                Read = true,
                Update = false,
                Delete = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            IList<Role> roles = new List<Role>() { admin, contributor, reader };

            context.Roles.AddRange(roles);

            base.Seed(context);
        }
        
    }
}
