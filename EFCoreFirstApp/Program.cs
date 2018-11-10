using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EFCoreFirstApp
{
	class Department
	{
		[Key]
		public int DepartmentId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}

	class Employee
	{
		public int EmployeeId { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
	}


	class Program
	{
		static void Main( string[] args )
		{

		}
	}
}
