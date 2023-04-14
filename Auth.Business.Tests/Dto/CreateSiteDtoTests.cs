using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Auth.Business.Tests.Dto
{
    public class CreateSiteDtoTests
    {
        [Fact]
        public void CreateOrgDto_Success()
        {
            CreateSiteDto site = new CreateSiteDto() { OrgId = 0 , Name = "Test Site" };
            Assert.Equal("Test Site", site.Name);
            Assert.Equal(0, site.OrgId);    
        }
    }
}
