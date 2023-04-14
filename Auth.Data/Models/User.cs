namespace Auth.Data.Models
{
    public class User
    {
        public User()
        {
            this.Sites = new HashSet<Site>();
            this.Roles = new HashSet<Role>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Org Org { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
