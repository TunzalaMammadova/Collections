using System;
using Domain.Models;
using Service.Data;
using Service.Interfaces;

namespace Service.Services
{
    public class AuthorService : IAuthorService
    {
        public List<Author> GetAllByAge(int age)
        {
            return AppDbContext.Authors().Where(m => m.Age > age).ToList();
        }
    }
}

