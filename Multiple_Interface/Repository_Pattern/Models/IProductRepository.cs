using System;
namespace Repository_Pattern.Models
{
	public interface IProductRepository
	{

		IEnumerable<Product> GetAllProducts();
		Product GetProduct(int id);
		Product Delete(int id);
		Product Add(Product product);
		Product Update(int id);

	}
}

