using Microsoft.AspNetCore.Identity;

namespace ss08_api.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
