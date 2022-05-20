using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBabeProjectLibrary.Models {
    public  class Project {

        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; } = null!;
        public int EstimatedHours { get; set; } 
        public int ActualHours { get; set; }
        [StringLength(30)]
        public string Status { get; set; } = "NEW";
        public virtual List<Work>? Works { get; set; }
        public virtual Resource? Resources { get; set; }
    }
}
