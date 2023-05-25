using Auth.Business.Interfaces;
using Auth.Data.Interfaces;
using Auth.Data.Models;
using System.Data;

namespace Auth.Business.Services
{
    public class TenantService : ITenantService
    {
        public IUnitOfWork _unitOfWork;

        public TenantService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Tenant Create(string name)
        {
            try
            {
                Tenant tenant = new Tenant(name);
                tenant = _unitOfWork.Tenants.Add(tenant);
                _unitOfWork.Tenants.Save();

                IEnumerable<Permission> permissions = AddDefaultPermissions(tenant.Id);
                IEnumerable<Role> roles = AddDefaultRoles(tenant.Id);
                AddDefaultRolePermissions(roles, permissions);

                return tenant;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Task<Tenant> Get(int id)
        {
            return _unitOfWork.Tenants.GetById(id);
        }

        public async Task<IEnumerable<Tenant>> GetAll()
        {
            return await _unitOfWork.Tenants.GetAll();
        }


        private IEnumerable<Role> AddDefaultRoles(int tenantId)
        {
            Role admin = new Role();
            admin.TenantId = tenantId;
            admin.Name = "ADMIN";

            Role contributor = new Role();
            contributor.TenantId = tenantId;
            contributor.Name = "CONTRIBUTOR";

            Role reader = new Role();
            reader.TenantId = tenantId;
            reader.Name = "READER";

            IEnumerable<Role> roles = new List<Role>() { admin, contributor, reader };
            roles = _unitOfWork.Roles.AddMany(roles);
            _unitOfWork.Roles.Save();

            return roles;

        }
        private IEnumerable<Permission> AddDefaultPermissions(int tenantId)
        {
            Permission create = new Permission();
            create.Name = "CREATE";
            create.TenantId = tenantId;

            Permission read = new Permission();
            read.Name = "READ";
            read.TenantId = tenantId;

            Permission update = new Permission();
            update.Name = "UPDATE";
            update.TenantId = tenantId;

            Permission delete = new Permission();
            delete.Name = "DELETE";
            delete.TenantId = tenantId;

            IEnumerable<Permission> permissions = new List<Permission>() { create, read, update, delete };
            permissions = _unitOfWork.Permissions.AddMany(permissions);
            _unitOfWork.Permissions.Save();

            return permissions;
        }
        private IEnumerable<RolePermission> AddDefaultRolePermissions(IEnumerable<Role> roles, IEnumerable<Permission> permissions)
        {
            Role admin = roles.Where(r => r.Name == "ADMIN").First();
            Role contributor = roles.Where(r => r.Name == "CONTRIBUTOR").First();
            Role reader = roles.Where(r => r.Name == "READER").First();

            Permission create = permissions.Where(p => p.Name == "CREATE").First();
            Permission read = permissions.Where(p => p.Name == "READ").First();
            Permission update = permissions.Where(p => p.Name == "UPDATE").First();
            Permission delete = permissions.Where(p => p.Name == "DELETE").First();

            RolePermission adminCreate = new RolePermission(admin.Id, create.Id);
            RolePermission adminRead = new RolePermission(admin.Id, read.Id);
            RolePermission adminUpdate = new RolePermission(admin.Id, update.Id);
            RolePermission adminDelete = new RolePermission(admin.Id, delete.Id);

            RolePermission ctbCreate = new RolePermission(contributor.Id, create.Id);
            RolePermission ctbRead = new RolePermission(contributor.Id, read.Id);
            RolePermission ctbUpdate = new RolePermission(contributor.Id, update.Id);

            RolePermission readerRead = new RolePermission(reader.Id, read.Id);

            IEnumerable<RolePermission> rolePerms = new List<RolePermission>()
            {
                adminCreate,
                adminRead,
                adminUpdate,
                adminDelete,
                ctbCreate,
                ctbRead,
                ctbUpdate,
                readerRead
            };

            return _unitOfWork.RolePermissions.AddMany(rolePerms);
        }
    }
}
