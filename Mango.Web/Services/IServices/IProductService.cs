using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> UpdateProductAsync<T>(ProductDTO productDTO);
        Task<T> CreateProductAsync<T>(ProductDTO productDTO);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
