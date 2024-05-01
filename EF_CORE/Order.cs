using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.EF_CORE
{
    [Table("Orders")]
    public class Order
    {
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public Guid UserId { get; set; } // foreign key to User 
        public User User { get; set; }
    }
}