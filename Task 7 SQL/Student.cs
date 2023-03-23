using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_LEO
{
	internal class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public virtual ICollection<Teacher> Teachers { get; set; }
	}
}
