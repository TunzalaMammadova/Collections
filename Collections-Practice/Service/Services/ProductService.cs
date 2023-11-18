using System;
using Domain.Models;
using Service.Data;
using Service.Interfaces;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.Products();
        }


        public List<Product> Search(string searchrext)
        {
            return AppDbContext.Products().Where(m => m.Name.Contains(searchrext)).ToList();
        }
    }
}

