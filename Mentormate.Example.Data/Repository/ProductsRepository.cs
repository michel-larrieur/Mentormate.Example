using Mentormate.Example.Domain.Repository;
using Mentormate.Example.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentormate.Example.Data.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ExampleContext _db;

        public ProductsRepository(ExampleContext db)
        {
            _db = db;
        }

        public async Task<Guid> SaveNewProductAsync(Product product)
        {
            product.Id = Guid.NewGuid();
            _db.Add(product);
            await _db.SaveChangesAsync();
            return product.Id;
        }
    }
}
