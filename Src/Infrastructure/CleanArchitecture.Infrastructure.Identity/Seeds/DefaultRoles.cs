using System.Threading.Tasks;
using CleanArchitecture.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<ApplicationRole> roleManager)
        {
            //Seed Roles
            if (!await roleManager.Roles.AnyAsync() && !await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new ApplicationRole("Admin"));
        }
    }
}
