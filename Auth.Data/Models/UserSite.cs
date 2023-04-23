using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Auth.Data.Models
{
    public class UserSite
    {
        public UserSite(User user, Site site, string role) 
        {
            UserId = user.Id;
            User = user;
            SiteId = site.Id;
            Site = site;
            Role = role;
        }
        public UserSite() 
        { 

        }

        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        public User User { get; set; }
        [Key, Column(Order = 1)]
        public int SiteId { get; set; }
        public Site Site { get; set; }
        public string Role { get; set; }
    }
}
