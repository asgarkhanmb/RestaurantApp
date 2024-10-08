using Microsoft.AspNetCore.Identity;

namespace Restaurant_App.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
