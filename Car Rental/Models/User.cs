using Microsoft.AspNetCore.Identity;

namespace Car_Rental.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
