using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace backend.model
{
    public class Workshop
    {
        [Key]
        public int WorkshopId { get; set; }

        [Required]
        public string WorkshopName { get; set; }
        public string WorkshopAddress { get; set; }
        public string Lecturer { get; set; }

        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
