using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Data.Models
{
    public class Permission
    {
        public Permission(int id, string name) 
        {
            Id = id;
            Name = name;
            RolePermissions = new HashSet<RolePermission>();

        }
        public Permission() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
