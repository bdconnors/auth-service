

using Auth.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Xml;
using EF6 = System.Data.Entity; // use EF6.DbContext for the EF6 version

namespace Auth.Data.Tests
{
    public class AuthorizationDbContextTests
    {
        private readonly EF6.DbContext _context;

        public AuthorizationDbContextTests()
        {
            var connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyDatabase;Integrated Security=True;MultipleActiveResultSets=True;";
            var database = new AuthorizationDbContext(connectionString);
            _context = database;
        }

        [Fact]
        public void Add()
        {
            using (_context)
            {
                var org = new Org { Name = "TestOrg" };
                _context.Set<Org>().Add(org);
                _context.SaveChanges();

                var savedOrg = _context.Set<Org>().FirstOrDefault(e => e.Id == org.Id);
                Assert.NotNull(savedOrg);
                Assert.Equal("TestOrg", savedOrg.Name);

                var site = new Site { Name = "TestSite", OrgId = org.Id, Org = org };
                _context.Set<Site>().Add(site);
                _context.SaveChanges();

                var savedSite = _context.Set<Site>().FirstOrDefault(e => e.Id == site.Id);
                Assert.NotNull(savedSite);
                Assert.Equal("TestSite", savedSite.Name);

                var user = new User { Email = "test@test.com", PasswordHash = "supersecurepass123#$", MobileNumber = "5555555555" };
                _context.Set<User>().Add(user);
                _context.SaveChanges();

                var savedUser = _context.Set<User>().FirstOrDefault(e => e.Id == user.Id);
                Assert.NotNull(savedUser);
                Assert.Equal("test@test.com", savedUser.Email);

                var userSite = new UserSite { User = user, UserId = user.Id, Site = site, SiteId = site.Id, Role = "ADMIN" };
                _context.Set<UserSite>().Add(userSite);
                _context.SaveChanges();

                var savedUserSite = _context.Set<UserSite>().FirstOrDefault(e => e.UserId == user.Id);
                Assert.NotNull(savedUserSite);
                Assert.Equal("ADMIN", savedUserSite.Role);
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}