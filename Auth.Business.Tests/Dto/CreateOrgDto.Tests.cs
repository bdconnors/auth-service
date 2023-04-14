using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Auth.Business.Tests.Dto
{
    public class CreateOrgDtoTests
    {
        [Fact]
        public void CreateOrgDto_Success()
        {
            CreateOrgDto org = new CreateOrgDto() { Name = "Test Org" };
            Assert.Equal("Test Org", org.Name);
        }
    }
}
