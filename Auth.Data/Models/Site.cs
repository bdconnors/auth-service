namespace Auth.Data.Models
{
    public class Site
    {
        public Site(Org org, string name)
        { 
            Org = org;
            Name = name;
            UserSites = new List<UserSite>();
        }
        public Site() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrgId { get; set; }
        public Org Org { get; set; }
        public ICollection<UserSite> UserSites { get; set; }
    }
}
