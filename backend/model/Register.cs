using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace backend.model
{
    public class Register
    {
        [Key]
        public int RegId { get; set; }

        [Required]
        public string UserId { get; set; }
        [Required]
        public string WorkshopId { get; set; }

        public String RegDate { get; set; }
        public String RegTime { get; set; }

    }
}
