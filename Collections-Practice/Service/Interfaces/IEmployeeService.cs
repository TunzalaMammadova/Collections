using System;
namespace Service.Interfaces
{
	public interface IEmployeeService
	{
		int GetCountByFilter(DateTime start, DateTime end, decimal salary);
	}
}

