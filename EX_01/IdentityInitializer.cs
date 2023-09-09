using Microsoft.AspNetCore.Identity;

namespace EX_01
{
    public class IdentityInitializer
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public IdentityInitializer (UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task SDas()
        {
            await Rrole(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
            await Rrole(new IdentityRole { Name = "Staff", NormalizedName = "STAFF" });
            var has = new PasswordHasher<IdentityUser>();
        }
        public async Task Rrole(IdentityRole role)
        {
            var exist = await roleManager.RoleExistsAsync(role.Name ?? "");
            if (exist)
            {
                await roleManager.CreateAsync(role);
            }
        }
       public async Task CRUser(IdentityUser user,string role)
        {
            var exist = await userManager.FindByNameAsync(user.UserName??"");
            if (exist == null)
            {
                await userManager.CreateAsync(user);
                await userManager.AddToRoleAsync(user, role);   
            }
        }
    }
}
