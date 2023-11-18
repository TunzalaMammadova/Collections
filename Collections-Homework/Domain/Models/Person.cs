using System;
namespace Domain.Models
{
	public class Person : BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Telephone { get; set; }
	}
}

