using BossBabeProjectLibrary.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBabeProjectLibrary {
    public class WorkController {

        public static void GetAllWork() {
            var _context = new AppDbContext();
            var works = _context.Works.ToList();
            foreach (var w in works) {
                Console.WriteLine(w);

            }
        }
        public static void GetWorkByResource(int resourceId) {
            var _context = new AppDbContext();
            var works = from w in _context.Works
                        join r in _context.Resources
                        on w.ResourceId equals r.Id
                        where r.Id == resourceId
                        select new { ResourceId = r.Id, Name = r.Name, WorkId = w.Id, Hours = w.Hours, Description = w.Description };
            works.ToList().ForEach(w => { global::System.Console.WriteLine($"Resource Id: {w.ResourceId} | Name:  {w.Name} | Work ID: {w.WorkId} | Hours: {w.Hours} | Description: {w.Description}"); });

        }
        public static void AddWork(int resourceId, string description, int hours) {
            var _context = new AppDbContext();
            var newWork = new Work();
            newWork.ResourceId = resourceId;
            newWork.Description = description;
            newWork.Hours = hours;
            _context.Works.Add(newWork);
            _context.SaveChanges();
        }

        public static void RemoveWork(int workId) {
            var _context = new AppDbContext();
            var removeWork = _context.Works.Find(workId);
            if (removeWork != null) {
                _context.Works.Remove(removeWork);
            }
        }
    }
}


 