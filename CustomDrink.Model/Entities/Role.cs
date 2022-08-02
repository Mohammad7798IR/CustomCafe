using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDrink.Model.Entities
{
    public partial class Role : BaseEntity
    {
        public string? Name { get; set; }

        public string? NormalizedName { get; set; }
    }

    public partial class Role
    {
        public ICollection<UserRole>? UserRoles { get; set; }
    }
}
