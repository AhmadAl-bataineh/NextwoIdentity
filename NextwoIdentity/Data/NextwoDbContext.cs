using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NextwoIdentity.Data
{
    public class NextwoDbContext:IdentityDbContext
    {
        public NextwoDbContext(DbContextOptions<NextwoDbContext> options):base(options) {
        }
    }
}
