using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Music
    {
        public int Id { get; set; }

        [Required]
        public string Artist  { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Playtime { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
