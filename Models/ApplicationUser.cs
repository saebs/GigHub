using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GigHub.Models
{
    public class ApplicationUser :  IdentityUser
    {
        public async Task<IdentityResult> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateAsync(this);
            return userIdentity;
        }
    }
}