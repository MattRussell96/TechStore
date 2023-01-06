using Microsoft.EntityFrameworkCore;
using TechStore.Server.Data;
using TechStore.Server.Entities;
using TechStore.Server.Repositories.Contracts;

namespace TechStore.Server.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TechStoreDbContext techStoreDbContext;

        public ProductRepository(TechStoreDbContext techStoreDbContext)
        {
            this.techStoreDbContext = techStoreDbContext;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.techStoreDbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.techStoreDbContext.Products.ToListAsync();

            return products;
        }
    }
}
