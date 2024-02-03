using System;

namespace Repository_Pattern.Models
{
	public class PoroductRepository : IProductRepository
	{
		public PoroductRepository()
		{
		}

        Product IProductRepository.Add(Product product)
        {
            /*
             * try
            {
                using (iakademi38Context context = new iakademi38Context())
                {
                    context.Add(product);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            */

            throw new NotImplementedException();
        }

        Product IProductRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IProductRepository.GetAllProducts()
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}

