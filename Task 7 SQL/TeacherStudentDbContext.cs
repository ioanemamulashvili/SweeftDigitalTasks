using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Task_7_LEO
{
	internal class TeacherStudentDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>()
					.HasMany<Teacher>(s => s.Teachers)
					.WithMany(t => t.Students)
					.Map(st =>
					{
						st.MapLeftKey("StudentId");
						st.MapRightKey("TeacherId");
						st.ToTable("StudentTeacher");
					});
		}
	}
}
