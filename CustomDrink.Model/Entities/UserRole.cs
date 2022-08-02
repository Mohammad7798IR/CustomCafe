using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDrink.Model.Entities
{
    public partial class UserRole : BaseEntity
    {
        public User? User { get; set; }

        public string? UserId { get; set; }

        public Role? Role { get; set; }

        public string? RoleId { get; set; }
    }
}
