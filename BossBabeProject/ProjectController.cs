


using BossBabeProjectLibrary.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BossBabeProjectLibrary {
    public class  ProjectController {

        
        public string ConnectionString { get; set; } = null!;
        public SqlConnection SqlConnection { get; set; } = null!;

        public ProjectController (string ServerInstance, string Database) {
            ConnectionString = $"server ={ServerInstance};" + $"database ={Database};" + "trustservercertificate=true;" + "trusted_connection = true;";
        }
        public void OpenConnection() {
            SqlConnection = new SqlConnection(ConnectionString);
            SqlConnection.Open();
            if (SqlConnection.State != System.Data.ConnectionState.Open) {
                throw new Exception("Connection did not open :(");
            }
        }
        public void CloseConnection() {
            SqlConnection.Close();
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