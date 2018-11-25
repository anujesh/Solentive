using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Model
{
    public class Track
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
