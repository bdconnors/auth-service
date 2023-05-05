using Auth.Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Auth.Business.Tests.Dto
{
    public class RegisterUserDtoTests
    {
        [Fact]
        public void RegisterUserDto_Success()
        {
            RegisterUserDto dto = new RegisterUserDto() { 
                Email = "test@test.com", 
                Password = "supersecure123@#",
                FirstName = "test",
                LastName = "tester",
                MobileNumber = "5555555555"
            };
            Assert.Equal("test@test.com", dto.Email);
            Assert.Equal("supersecure123@#", dto.Password);
            Assert.Equal("test", dto.FirstName);
            Assert.Equal("tester", dto.LastName);
            Assert.Equal("5555555555", dto.MobileNumber);
        }
    }
}
