using Auth.Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Auth.Business.Tests.Dto
{
    public class RegisterUserDtoSiteTests
    {
        [Fact]
        public void RegisterUserSiteDto_Success()
        {
            RegisterUserSiteDto dto = new RegisterUserSiteDto()
            {
                UserId = 0,
                SiteId = 0,
                Role = "ADMIN"
            };
            Assert.Equal(0, dto.UserId);
            Assert.Equal(0, dto.SiteId);
            Assert.Equal("ADMIN", dto.Role);
        }
    }
}
