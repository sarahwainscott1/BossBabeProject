using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBabeProjectLibrary.Models {
    public class Resource {

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public virtual Project? projects { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = null!;
        public int HoursPerDay { get; set; }
        public virtual List<Work>? Works { get; set; }


        public override string ToString() {
            return $"ID[{Id} | ProjectId {ProjectId} | Name {Name} |  Hours per Day {HoursPerDay}]";

            }
        }
    }

