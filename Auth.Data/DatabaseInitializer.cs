using Auth.Data.Models;
using System.Data.Entity;

namespace Auth.Data
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            Permission create = new Permission() 
            { 
                Title = "CREATE", 
                Description = "Add Data", 
                Label = "Create",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            Permission read = new Permission() 
            { 
                Title = "READ", 
                Description = "Get Data", 
                Label = "Read",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            Permission update = new Permission() 
            { 
                Title = "UPDATE", 
                Description = "Modify Data",
                Label = "Update",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            Permission delete = new Permission() 
            { 
                Title = "DELETE", 
                Description = "Remove Data", 
                Label = "Delete",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            Role admin = new Role() 
            { 
                Title = "ADMIN", 
                Description = "Create, Read, Update, and Delete Permissions", 
                Label = "Admin",
                Permissions = new List<Permission>() { create, read, update, delete },
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            Role contributor = new Role()
            {
                Title = "CONTRIBUTOR",
                Description = "Create, Read, and Update Permissions",
                Label = "Data Contributor",
                Permissions = new List<Permission>() { create, read, update },
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            Role reader = new Role()
            {
                Title = "READER",
                Description = "Read Permission",
                Label = "Data Reader",
                Permissions = new List<Permission>() { create },
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            IList<Role> roles = new List<Role>() { admin, contributor, reader };

            context.Roles.AddRange(roles);

            base.Seed(context);
        }
        
    }
}
