using System;
using System.Collections.Generic;
using System.Text;

namespace Mentormate.Example.Entities.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
    }
}
