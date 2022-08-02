using System.ComponentModel.DataAnnotations;



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
    }
}
