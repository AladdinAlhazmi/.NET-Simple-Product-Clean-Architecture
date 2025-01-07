using System;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Infrastructure.Identity.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
