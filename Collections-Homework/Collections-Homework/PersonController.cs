using System;
using System.Xml.Linq;
using Domain.Models;
using Service.Interfaces;
using Service.Services;

namespace Collections_Homework
{
	public class PersonController
	{
		private readonly IPersonService _personService;

		public PersonController()
		{
			_personService = new PersonService();	
		}

		public void GetAll()
		{
            _personService.Persons();

            
          
        }

        public void Delete()
        {
            string phoneNumber = Console.ReadLine();

            var res = _personService.Delete(phoneNumber);

            Console.WriteLine(res);
          

        }
    }
}

