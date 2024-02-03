using System;
namespace Repository_Pattern.Models
{
	public interface ICategoryRepository
	{

        IEnumerable<Category> GetAllCategorys();
        Category GetCategory(int id);
        Category Delete(int id);
        Category Add(Category category);
        Category Update(int id);

    }
}

