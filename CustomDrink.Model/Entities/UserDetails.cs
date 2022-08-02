using System.ComponentModel.DataAnnotations;

namespace CustomDrink.Model.Entities
{
    public partial class UserDetails
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }
    }

    public partial class UserDetails
    {
        public User? User { get; set; }

        public string? UserId { get; set; }
    }
}
