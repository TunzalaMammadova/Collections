using System;
using Service.Interfaces;
using Service.Services;

namespace Collections_Practice.Controllers
{
	public class AuthorController
	{
		private readonly IAuthorService _authorService;

		public AuthorController()
		{
			_authorService = new AuthorService();

		}


		public void GetAllByAge()
		{
			int age = 24;
			var response = _authorService.GetAllByAge(age);

			foreach (var item in response)
			{
				string res = $"{item.Name} - {item.Surname}";
				Console.WriteLine(res);
			}
		}
	}
}

