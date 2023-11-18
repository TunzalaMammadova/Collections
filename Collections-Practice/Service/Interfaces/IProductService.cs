using System;
using Domain.Models;

namespace Service.Interfaces
{
	public interface IProductService
	{
		List<Product> GetAll();
        List<Product> Search(string searchtext);
    }
}

