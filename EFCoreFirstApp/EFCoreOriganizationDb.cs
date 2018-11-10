using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreFirstApp
{
	class EFCoreOriganizationDb : DbContext
	{
		string ConnectString = "Host=localhost;Port=5432;Database=EFCoreOrganization;Username=postgres;Password=0000";
		protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
		{
			//base.OnConfiguring( optionsBuilder );
			optionsBuilder.UseNpgsql( @ConnectString );

		}

		public DbSet<Department> Departments { get; set; }
		public DbSet<Employee> Employees { get; set; }
	}
}
