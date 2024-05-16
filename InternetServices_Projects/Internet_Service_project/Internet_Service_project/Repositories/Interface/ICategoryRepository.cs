using Internet_Service_project.Models;
using System.Collections.Generic;

namespace Internet_Service_project.Repositories
{
    public interface ICategoryRepository
    {
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
