using System;
using Service.Interfaces;
using Service.Services;

namespace Collections_Practice.Controllers
{
	public class EmployeeController
	{
		private readonly IEmployeeService _employeeService;

		public EmployeeController()
		{
			_employeeService = new EmployeeService();
		}

		public void GetCountByFilter()
		{
			decimal salary = 1000;
			DateTime start = new DateTime(1990, 01, 01);
			DateTime end = new DateTime(2000, 01, 01);

			var res = _employeeService.GetCountByFilter(start, end, salary);

			Console.WriteLine(res);
        }
    }
	

}

