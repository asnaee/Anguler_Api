using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EX_01
{
    public class appdb : IdentityDbContext<IdentityUser>
    {
        public appdb(DbContextOptions<appdb>options):base(options) { }
    }
}
