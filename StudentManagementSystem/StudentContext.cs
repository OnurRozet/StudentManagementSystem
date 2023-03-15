using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
	public static class StudentContext
	{
		public static List<Student> Students = new List<Student>
		{
			new Student{Id=1, Name="Onur",Surname="Rozet",Branch="A"},
		    new Student{Id=2, Name="Ahmet Selçuk",Surname="Ozyurt",Branch="A"},
		    new Student{Id=3, Name="Hasan Kemal",Surname="Itisken",Branch="B"},
		    new Student{Id=4, Name="Ömer Faruk",Surname="Doğru",Branch="B"},
		    new Student{Id=5, Name="AHmet Tolga",Surname="Odabaşı",Branch="C"},
		};
	}
}
