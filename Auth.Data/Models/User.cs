namespace Auth.Data.Models
{
    public class User
    {
        public User(string email, string pass, string? mobileNumber) 
        {
            Email = email;
            PasswordHash = pass;
            MobileNumber = mobileNumber;
            UserSites = new List<UserSite>();
        }
        public User() { }
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string? MobileNumber { get; set; }
        public ICollection<UserSite> UserSites { get; set; }
    }
}
