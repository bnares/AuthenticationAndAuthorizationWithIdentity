using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

namespace ArtGuard.Models.Domain
{
    public class ArtGuardDbContext : IdentityDbContext<ApplicationUser>
    {
        public ArtGuardDbContext(DbContextOptions<ArtGuardDbContext> options) : base(options) 
        {

        }
    }
}
