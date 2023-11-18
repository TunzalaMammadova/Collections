using System;
using Domain.Models;

namespace Service.Interfaces
{
	public interface IUserService
	{
		bool Login(string email, string password);
	}
}

