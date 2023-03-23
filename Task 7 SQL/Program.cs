using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_7_LEO
{
	internal class Program
	{
		static void Main(string[] args)
		{

			using (var context = new TeacherStudentDbContext())
			{
				var teacher1 = new Teacher { Name = "Maia" };
				var teacher2 = new Teacher { Name = "Natia" };
				var teacher3 = new Teacher { Name = "Gurami" };
			
				var student1 = new Student { Name = "Levani", LastName = "Abashidze", Teachers = new List<Teacher> { teacher1, teacher2 } };
				var student2 = new Student { Name = "Giorgi", LastName = "Mamulashvili", Teachers = new List<Teacher> { teacher1, teacher3 } };
			
				context.Students.Add(student1);
				context.Students.Add(student2);
			
				context.Teachers.Add(teacher1);
				context.Teachers.Add(teacher2);
				context.Teachers.Add(teacher3);
			
				context.SaveChanges();
			}

			using (var context = new TeacherStudentDbContext())
			{
				var teachers = context.Teachers
						.Where(t => t.Students.Any(s => s.Name == "Giorgi"))
						.ToList();

				foreach (var teacher in teachers)
				{
					Console.WriteLine($"Teacher {teacher.Name} teaches at least one student named Giorgi.");
				}
			}

			Console.ReadKey();
		}
	}
}
