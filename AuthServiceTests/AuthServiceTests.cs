using Data;
using Data.Entities;
using FinalDemoForms.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServiceTests
{
    public class AuthServiceTests : IDisposable
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public AuthServiceTests()
        {
            _options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName:"TestDatabase")
                .Options;

            using (var context = new AppDbContext(_options))
            {
                context.Master.Add(new Master
                {
                    MasterLogin = "testuser",
                    MasterPassword = "testpassword"
                });
                context.SaveChanges();
            }
        }
        [Fact]
        public void Authenticate_ValidCredentials_ReturnsTrue()
        {
            using (var context = new AppDbContext(_options))
            {
                var authService = new AuthService(context);

                var result = authService.Authenticate("testuser", "testpassword");

                Assert.True(result);
            }
        }
        [Fact]
        public void Authenticate_InvalidCredentials_ReturnsFalse()
        {
            using (var context = new AppDbContext(_options))
            {
                var authService = new AuthService(context);

                var result = authService.Authenticate("wronguser", "wrongpassword");

                Assert.False(result);
            }
        }
        [Fact]
        public void Authenticate_EmptyCredentials_ReturnsFalse()
        {
            using (var context = new AppDbContext(_options))
            {
                var authService = new AuthService(context);

                var result = authService.Authenticate("", "");

                Assert.False(result);
            }
        }
        public void Dispose()
        {
            using (var context = new AppDbContext(_options))
            {
                context.Database.EnsureDeleted();
            }
        }
    }
}
