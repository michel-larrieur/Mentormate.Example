using Mentormate.Example.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentormate.Example.Data
{
    public class ExampleContext: DbContext
    {

        public ExampleContext() {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseInMemoryDatabase($"MentormateExample");

        public DbSet<Product> Products { get; set; }

    }
}
