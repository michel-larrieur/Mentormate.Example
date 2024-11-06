using Mentormate.Example.Domain.Repository;
using Mentormate.Example.Entities.Commands;
using Mentormate.Example.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentormate.Example.Domain.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductService(IProductsRepository productsRepository)
        {
            this._productsRepository = productsRepository;
        }

        public async Task<Guid> CreateProductAsync(CreateProductCommand product)
        {
            var id = await _productsRepository.SaveNewProductAsync(new Product
            {
                Name = product.Name,
                Description = product.Description,
                CreatedBy = product.CreatedBy,
                CreatedDate = DateTime.Now
            });
            return id;
        }
    }
}
