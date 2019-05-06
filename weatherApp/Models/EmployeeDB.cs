using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace weatherApp.Models
{
	public class EmployeeDB
	{
		EmployeeEntities db;
		public EmployeeDB()
		{
			db = new EmployeeEntities();
		}

		//Select Methods
		public IEnumerable<Employee> getEmployeesKingstonIT(string role, string location)
		{
			return from c in db.Employee
				   orderby c.Id
				   where c.empRole == role
				   where c.addressLocation == location
				   select c;
		}

		public IEnumerable<Employee> GetEmployees()
		{
			return from c in db.Employee
				   orderby c.Id
				   select c;
		}
	}
}