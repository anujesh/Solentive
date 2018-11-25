using System.ComponentModel.DataAnnotations;

namespace Solentive.Interview.Model
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string RoomNumber { get; set; }

        [Required]
        public string Building { get; set; }
    }
}
