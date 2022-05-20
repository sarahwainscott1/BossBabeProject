using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models {
    public  class Resource {

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public virtual Project? projects { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = null!;
        public int HoursPerDay { get; set; }


    }
}
