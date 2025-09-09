using Microsoft.AspNetCore.Identity;

namespace Restaurant.Models
{
    public class User : IdentityUser
    {

        public string FullName { get; set; }

    }
}