using System;
using Domain.Models;

namespace Service.Data
{
	public static class AppDbContext
	{
		public static List<Author> Authors()
		{
			return new List<Author>()
			{
				new Author { Id = 1, Name = "Tunzale", Surname = "Memmedova", Age = 24 },
				new Author { Id = 2, Name = "Arzu", Surname = "Kerimli", Age = 25 },
				new Author { Id = 3, Name = "Nise", Surname = "Nerimanova", Age = 26 },
				new Author { Id = 4, Name = "Meryem", Surname = "Eliyeva", Age = 23 },
				new Author { Id = 5, Name = "Metanet", Surname = "Abbasova", Age = 21 }
			};
		}


        public static List<Employee> Employees()
        {
            return new List<Employee>()
            {
                new Employee { Id = 1, Name = "Aqshin", Surname = "Veliyev", Birthday = new(1998,03,01), Salary = 1760 },
                new Employee { Id = 2, Name = "Oruc", Surname = "Mehrabov", Birthday = new(1997,12,03), Salary = 800 },
                new Employee { Id = 3, Name = "Ilham", Surname = "Abasli", Birthday = new(2002,01,01), Salary = 120},
                new Employee { Id = 5, Name = "Semed", Surname = "Huseynov", Birthday = new(1997,01,01), Salary = 80 }
            };
        }


		public static List<User> Users()
		{
			return new List<User>()
			{
				new User{Id = 1, Email = "t@gmail.com" , Password = "123"},
				new User{Id = 2, Email = "s@gmail.com" , Password = "1234"}
			};
		}


		public static List<Product> Products()
		{
			return new List<Product>()
			{
				new Product{Id = 1, Name = "Iphone", Count = 10, Price = 2000 },
				new Product{Id = 2, Name = "Nokia", Count = 20, Price = 1000 },
				new Product{Id = 3, Name = "Samsung", Count = 5, Price = 1500 }
			};
		}
    }
}

