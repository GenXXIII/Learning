using Microsoft.AspNetCore.Identity;

namespace Registation.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
