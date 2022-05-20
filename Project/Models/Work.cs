using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models {
    public class Work {

        public int Id { get; set; }

        public int ProjectId { get; set; }
        public virtual Project? Projects { get; set; }

        public int ResourceId { get; set; }
        public virtual Resource? Resources { get; set; }

        [StringLength(50)]
        public string Description { get; set; } = null!;

        public int Hours { get; set; }

    }
}
