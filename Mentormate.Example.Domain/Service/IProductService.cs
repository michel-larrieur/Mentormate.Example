using Mentormate.Example.Entities.Commands;
using Mentormate.Example.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentormate.Example.Domain.Service
{
    public interface IProductService
    {
        Task<Guid> CreateProductAsync(CreateProductCommand product);
    }
}
