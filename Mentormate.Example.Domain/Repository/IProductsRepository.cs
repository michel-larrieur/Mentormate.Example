using Mentormate.Example.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentormate.Example.Domain.Repository
{
    public interface IProductsRepository
    {
        Task<Guid> SaveNewProductAsync(Product product);
    }
}
