using BossBabeProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBabeProjectLibrary.Models {
    public class ResourceController {

        public static void GetAllResources() {
            var _context = new AppDbContext();
            var resources = _context.Resources.ToList();
            foreach (var r in resources) {
                Console.WriteLine(r);
                }
            }
        }
    }
