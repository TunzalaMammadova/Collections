using System;
using Domain.Models;
using Service.Data;
using Service.Interfaces;

namespace Service.Services
{
    public class UserService : IUserService
    {
        public bool Login(string email, string password)
        {
            return AppDbContext.Users().Exists(m => m.Email == email && m.Password == password);
        }
    }
}

