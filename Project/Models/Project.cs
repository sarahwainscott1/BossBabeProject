using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models {
    public  class Project {

        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; } = null!;
        public int EstimatedHours { get; set; } 
        public int ActualHours { get; set; }
        [StringLength(30)]
        public string Status { get; set; } = "NEW";

    }
}
