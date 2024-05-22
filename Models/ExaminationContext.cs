using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Models
{
    public class ExaminationContext:DbContext
    {
        public DbSet<student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<St_Ex> St_Ex { get; set; }
        public DbSet<Student_Subjects> Student_Subjects { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Examination;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<student>()
			//	.HasIndex(s => s.UserName)
			//	.IsUnique();
            modelBuilder.Entity<student>()
               .HasIndex(s => s.Password)
               .IsUnique();
		}
	}
}
