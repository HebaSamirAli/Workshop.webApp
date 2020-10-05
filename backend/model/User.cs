using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace backend.model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }
        public string UserEmail { get; set; }

        public String UserTel { get; set; }
        
        [Required]
        public String Password { get; set; }
        public Boolean Admin { get; set; }
    }
}
