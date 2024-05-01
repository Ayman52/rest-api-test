using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class UserModel
    {
        [Required]
        public Guid UserId { get; set; }
        public string Name { get; set; }
        // public DateTime CreatedAt { get; set; }
        public string Email { get; set; }

        public ProfileModel Profile { get; set; } // 1-1 relation
        public List<OrderModel> Orders { get; set; }  // 1 - many relation
    }
}