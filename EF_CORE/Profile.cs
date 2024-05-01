using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.EF_CORE
{
    [Table("Profiles")]
    public class Profile
    {
        public Guid ProfileId { get; set; }
        public string Bio { get; set; }
        public Guid UserId { get; set; } // foreign 
        public User User { get; set; } // 1-1 relation 
    }
}