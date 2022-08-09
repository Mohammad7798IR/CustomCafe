using System.ComponentModel.DataAnnotations;
using static System.Formats.Asn1.AsnWriter;

namespace CustomDrink.Model.Entities
{
    public partial class User : BaseEntity
    {
        public string? Password { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

    }
    public partial class User
    {
        public ICollection<UserDetails>? UserDetails { get; set; }

        public ICollection<UserRole>? UserRoles { get; set; }

        public Store? Store { get; set; }
    }
}
