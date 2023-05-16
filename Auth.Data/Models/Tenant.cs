namespace Auth.Data.Models
{
    public class Tenant
    {
        public Tenant(string name) 
        {
            Name = name;
            Users = new HashSet<User>();
            Roles = new HashSet<Role>();
            Permissions = new HashSet<Permission>();
        }
        public Tenant() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
