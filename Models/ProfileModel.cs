using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class ProfileModel
    {
        public Guid ProfileId { get; set; }
        public string Bio { get; set; }
        public Guid UserId { get; set; } // foreign 
        public UserModel User { get; set; } // 1-1 relation 
    }
}