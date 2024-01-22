

using Core.Entities;

namespace Core.Interfaces
{
    public interface iProductRepository
    {
    
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);

        
    }
}