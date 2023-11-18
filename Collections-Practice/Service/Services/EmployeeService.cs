using System;
using Service.Data;
using Service.Interfaces;

namespace Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        public int GetCountByFilter(DateTime start, DateTime end, decimal salary)
        {
            return AppDbContext.Employees().Where(m => m.Birthday > start && m.Birthday < end && m.Salary > salary).Count();
        }
    }
}

