using System;
using Service.Interfaces;
using Service.Services;

namespace Collections_Practice.Controllers
{
	public class AccountController
	{
		private readonly IUserService _userService;

		public AccountController()
		{
			_userService = new UserService();
		}

		public bool Login()
		{
			Console.WriteLine("Enter your email");
			Email: string email = Console.ReadLine();

			Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

			bool response = _userService.Login(email, password);

			if (!response)
			{
				Console.WriteLine("Email or password is wrong please inputs again");
				goto Email;
			}

			return true;
        }
	}
}

