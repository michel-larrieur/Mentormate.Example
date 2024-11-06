using System.ComponentModel.DataAnnotations;

namespace Mentormate.Example.Controllers.Models
{
    public class CreateProductDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
