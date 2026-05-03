using CrudDemoApi.Models;

namespace CrudDemoApi.Services
{
    public interface IProductService
    {
        List<Product> GetAll(int pageNumber, int pageSize);
        Product GetById(int id);
        Product Create(Product product);
        Product Update(int id, Product product);
        bool Delete(int id);
    }
}