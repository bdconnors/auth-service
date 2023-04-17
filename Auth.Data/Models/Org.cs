namespace Auth.Data.Models
{
    public class Org
    {
        public Org() 
        {
            this.Sites = new HashSet<Site>();
            this.Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Site> Sites { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
