using Microsoft.EntityFrameworkCore;
using BossBabeProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBabeProjectLibrary.Models {
    public class AppDbContext : DbContext {
        public AppDbContext() { }

        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<Resource> Resources { get; set; } = null!;
        public DbSet<Work> Works { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("server=localhost\\sqlexpress;database=BossBabeProject;trustservercertificate=true;trusted_connection=true;");
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}