using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDrink.Model.Entities
{
    public partial class Store : BaseEntity
    {
        public string? Address { get; set; }

        [MaxLength(30)]
        public string? Name { get; set; }
    }

    public partial class Store
    {
        public User? User { get; set; }

        public string? UserId { get; set; }
    }
}
