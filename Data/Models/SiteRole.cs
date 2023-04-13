namespace Auth.Data.Models
{
    public class SiteRole
    {
        public int Id { get; set; }
        public Site Site { get; set; }
        public Role Role { get; set; }
    }
}
