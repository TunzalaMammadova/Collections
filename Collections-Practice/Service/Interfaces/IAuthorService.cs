using System;
using Domain.Models;

namespace Service.Interfaces
{
	public interface IAuthorService
	{
		List<Author> GetAllByAge(int age);
	}
}

