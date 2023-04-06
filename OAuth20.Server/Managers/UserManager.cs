using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OAuth20.Server.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OAuth20.Server.Managers
{
    public class AppUserManager : UserManager<AppUser>
    {
        private List<AppUser> AppUsers = new List<AppUser>() { 
            new AppUser() { Id = new Guid("0031e891-cf4e-426e-b1da-1d7074a81e94").ToString(), UserName = "mbj@diviso.dk", Email = "mbj@diviso.dk" },
            new AppUser() { Id = new Guid("abe1e891-cf4e-426e-b1da-1d7074a81e94").ToString(), UserName = "dev@diviso.dk", Email = "dev@diviso.dk" },
            new AppUser() { Id = new Guid("8aa6b3d5-889f-45a8-8a2e-cf7f57730dba").ToString(), UserName = "testmbj@diviso.dk", Email = "testmbj@diviso.dk" }};


        public AppUserManager(IUserStore<AppUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<AppUser> passwordHasher, IEnumerable<IUserValidator<AppUser>> userValidators, IEnumerable<IPasswordValidator<AppUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<AppUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
  
        }

        public override async Task<AppUser> FindByEmailAsync(string email)
        {
            return AppUsers.FirstOrDefault(x => x.Email == email);
        }

        public override async Task<AppUser> FindByNameAsync(string userName)
        {
            return AppUsers.FirstOrDefault(x => x.UserName == userName);
        }

        public override async Task<IdentityResult> CreateAsync(AppUser user, string password)
        {
            AppUsers.Add(user);
            return new IdentityResult();

        }

        public override async Task<IdentityResult> CreateAsync(AppUser user)
        {
            AppUsers.Add(user);
            return new IdentityResult();
        }


    }
}
