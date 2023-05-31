using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Business.Dto
{
    public class CreateUserDto
    {
        public int TenantID { get; set; }
        public IEnumerable<int> Roles { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }  
        public string Password { get; set; }
        public string? MobileNumber { get; set; }

    }
}
