using System.ComponentModel.DataAnnotations;

namespace Solentive.Interview.Model
{
    public class Level
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int? Scaling { get; set; }
    }
}
