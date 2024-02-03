using System;

namespace Repository_Pattern.Models
{
	public class CategoryRepository : ICategoryRepository
	{
		public CategoryRepository()
		{
		}

        Category ICategoryRepository.Add(Category category)
        {
            throw new NotImplementedException();
        }

        Category ICategoryRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Category> ICategoryRepository.GetAllCategorys()
        {
            throw new NotImplementedException();
        }

        Category ICategoryRepository.GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        Category ICategoryRepository.Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}

