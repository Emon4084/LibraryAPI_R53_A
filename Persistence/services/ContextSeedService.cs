using AutoMapper.Execution;
using LibraryAPI_R53_A.Core;
using LibraryAPI_R53_A.Core.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LibraryAPI_R53_A.Persistence.services
{
    #region Seed Value for role. R-Step 02
    public class ContextSeedService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public ContextSeedService(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager; 
            _roleManager = roleManager;
        }

        public async Task InitializeContextAsync()
        {
            if(_context.Database.GetPendingMigrationsAsync().GetAwaiter().GetResult().Count() > 0) 
            {
                await _context.Database.MigrateAsync();
            }

            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = SD.AdminRole });
                await _roleManager.CreateAsync(new IdentityRole { Name = SD.ManagerRole });
                await _roleManager.CreateAsync(new IdentityRole { Name = SD.UserRole });
            }

            if (!_userManager.Users.AnyAsync().GetAwaiter().GetResult())
            {
                var admin = new ApplicationUser
                {
                    UserName = SD.AdminUserName,
                    Email = SD.AdminUserName,
                    EmailConfirmed = true
                };
                await _userManager.CreateAsync(admin, "123456");
                await _userManager.AddToRolesAsync(admin, new[] { SD.AdminRole, SD.ManagerRole, SD.UserRole });
                await _userManager.AddClaimsAsync(admin, new Claim[]
                {
                    new Claim(ClaimTypes.Email, admin.Email),
                    new Claim(ClaimTypes.GivenName, admin.UserName)
                });

                var manager = new ApplicationUser
                {
                    UserName = "manager",
                    Email = "manager@mail.com",
                    EmailConfirmed = true
                };
                await _userManager.CreateAsync(manager, "123456");
                await _userManager.AddToRoleAsync(manager, SD.ManagerRole);
                await _userManager.AddClaimsAsync(manager, new Claim[]
                {
                    new Claim(ClaimTypes.Email, manager.Email),
                    new Claim(ClaimTypes.GivenName, manager.UserName)
                });

                var user = new ApplicationUser
                {
                    UserName = "user",
                    Email = "user@mail.com",
                    EmailConfirmed = true
                };
                await _userManager.CreateAsync(user, "123456");
                await _userManager.AddToRoleAsync(user, SD.UserRole);
                await _userManager.AddClaimsAsync(user, new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.GivenName, user.UserName)
                });

                var subscribeUser = new ApplicationUser
                {
                    UserName = "subscribeUser",
                    Email = "subscribeuser@mail.com",
                    EmailConfirmed = true
                };
                await _userManager.CreateAsync(subscribeUser, "123456");
                await _userManager.AddToRoleAsync(subscribeUser, SD.UserRole);
                await _userManager.AddClaimsAsync(subscribeUser, new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.GivenName, user.UserName)
                });
            }
        }

        #endregion 
    }
}
