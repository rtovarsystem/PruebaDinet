
using DinetApi.Models;

namespace DinetApi.Interfaces
{
    public interface IProductosRepository
    {
        Task<IEnumerable<Productos>> GetAllProductosAsync();
        //Task<Product> GetProductByIdAsync(int id);
        Task<Productos> CreateProductosAsync(Productos model);
        //Task<bool> UpdateProductAsync(Product Product);
        //Task<bool> DeleteProductAsync(int id);
    }
}
