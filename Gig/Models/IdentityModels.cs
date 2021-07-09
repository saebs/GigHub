using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Gig.Models
{
    public class IdentityModels
    {
        
    }

    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentity()
        {
            var userIdentity = await GenerateUserIdentity();
            return userIdentity;

        }
    }
}