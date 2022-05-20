


using BossBabeProjectLibrary.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BossBabeProjectLibrary {
    public class  ProjectController {


   
        public static void  GetAllProjects() {
            var _context = new AppDbContext();
            var projects = _context.Projects.ToList();
            foreach( var p in projects) {
                Console.WriteLine(p);
                }
            
            }




            public static Project UpdateHoursWorked(int workId) {
            var _context = new AppDbContext();
            var work = _context.Works.SingleOrDefault(x => x.Id == workId);
            var project = _context.Projects.SingleOrDefault(x => x.Id == work.ProjectId);
            var linesHours = (from w in _context.Works
                            join p in _context.Projects
                            on w.ProjectId equals p.Id
                            where w.Id == workId
                            select new { w.Hours });
            foreach (var line in linesHours) {
                project.ActualHours += line.Hours;
            }
            return project;
        }
    }
}