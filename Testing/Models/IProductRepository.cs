using System;
using System.Collections.Generic;

namespace Testing.Models
{
	public interface IProductRepository
	{
        public Product AssignCategory();

        public void DeleteProduct(Product product);

        public IEnumerable<Product> GetAllProducts();

        public IEnumerable<Category> GetCategories();

        public Product GetProduct(int id);

        public void InsertProduct(Product productToInsert);

        public void UpdateProduct(Product product);
	}
}

