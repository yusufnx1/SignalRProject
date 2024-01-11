using Microsoft.AspNetCore.Identity;

namespace SignalRProject.Entities.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
