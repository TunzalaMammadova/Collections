using System;
using Domain.Datas;
using Domain.Models;
using Service.Interfaces;

namespace Service.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> Add()
        {
            Console.WriteLine("Name:");
            Name: string name = Console.ReadLine();
            if (name == " ")
            {
                Console.WriteLine("Input cannot be empty");
                goto Name;
            }


            Console.WriteLine("Surname:");
            Surname: string surname = Console.ReadLine();
            if (surname == " ")
            {
                Console.WriteLine("Input cannot be empty");
                goto Surname;
            }


            Console.WriteLine("Phone number:");
            PhoneNumber: string number = Console.ReadLine();
            if (number == " ")
            {
                Console.WriteLine("Input cannot be empty");
                goto PhoneNumber;
            }

            return AppDbContext.Persons();

        }

        public List<Person> Delete(string name ,string surname, string phoneNumber)
        {
                
            
        }



    }
}   

