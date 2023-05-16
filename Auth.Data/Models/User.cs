namespace Auth.Data.Models
{
    public class User
    {
        public User(string firstName, string lastName, string email, string pass, string? mobileNumber) 
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = pass;
            MobileNumber = mobileNumber;
            UserRoles = new HashSet<UserRole>();
        }
        public User() { }
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string? MobileNumber { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
