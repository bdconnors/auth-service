using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Business.Dto
{
    public class RegisterUserSiteDto
    {
        public int UserId { get; set; } 
        public int SiteId { get; set; }
        public string Role { get; set; }
    }
}
