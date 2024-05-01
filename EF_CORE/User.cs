using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.EF_CORE
{
    [Table("Users")]
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        // public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string Email { get; set; }
        public Profile Profile { get; set; } // 1-1 relation
        public List<Order> Orders { get; set; } // 1-many relation
    }
}