using System;
using Domain.Models;

namespace Service.Interfaces
{
	public interface IPersonService
	{
		List<Person> Persons();
		public List<Person> Delete(string phoneNumber);

    }
}

