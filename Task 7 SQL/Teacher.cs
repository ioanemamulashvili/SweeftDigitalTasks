using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_LEO
{
	internal class Teacher
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual ICollection<Student> Students { get; set; }
	}
}
