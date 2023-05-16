using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Data.Models
{
    public class Role
    {
        public Role(int id, int name) 
        { 
            Id = id;
            Name = name;
            RolePermissions = new HashSet<RolePermission>();
        }

        public Role() { }

        public int Id { get; set; }
        public int Name { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
