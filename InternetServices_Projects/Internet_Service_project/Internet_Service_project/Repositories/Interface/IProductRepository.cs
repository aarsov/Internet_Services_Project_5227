using Internet_Service_project.Models;
using System.Collections.Generic;

namespace Internet_Service_project.Repositories
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
