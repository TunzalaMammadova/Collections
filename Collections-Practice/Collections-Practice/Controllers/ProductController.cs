using System;
using Service.Data;
using Service.Interfaces;
using Service.Services;

namespace Collections_Practice.Controllers
{
	public class ProductController
	{
		private readonly IProductService _productService;

		public ProductController()
		{
			_productService = new ProductService();
		}


		public void GetAll()
		{
			var response = _productService.GetAll();

            foreach (var item in response)
            {
                string res = $"{item.Name} - {item.Count} - {item.Price}";
                Console.WriteLine(res);
            }
        }


        public void Search()
        {
            Console.WriteLine("Please add search text");
            string searchtext = Console.ReadLine();

            var response = _productService.Search(searchtext);

            foreach (var item in response)
            {
                string res = $"{item.Name} - {item.Count} - {item.Price}";
                Console.WriteLine(res);
            }
        }
    }
}

