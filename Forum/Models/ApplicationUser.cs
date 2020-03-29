using Microsoft.AspNetCore.Identity;

namespace Forum.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool? IsBlocked { get; set; }
    }
}
