using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Business.Dto
{
    public class RegisterUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string? MobileNumber { get; set; }
    }
}
