using System;
using Domain.Models;

namespace Domain.Datas
{
	public class AppDbContext
	{
        public static List<Person> Persons()
        {
            return new List<Person>()
            {
                new Person{Id = 1, Name = "Tunzale", Surname = "Memmedova", Telephone = "994516667788"},
                new Person{Id = 2, Name = "Elnur", Surname = "Memmedov", Telephone = "994709996655"},
                new Person{Id = 3, Name = "Semed", Surname = "Huseynov", Telephone = "994503334455"},
                new Person{Id = 4, Name = "Nergiz", Surname = "Memmedov", Telephone = "994554442233"},
            };
        }
    }
}

