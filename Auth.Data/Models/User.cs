namespace Auth.Data.Models
{
    public class User
    {
        public User(string email, string pass) 
        {
            Email = email;
            PasswordHash = pass;
            UserSites = new List<UserSite>();
        }
        public User() { }
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<UserSite> UserSites { get; set; }
    }
}
