using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phidbac.Domain.Models
{
    public class Book : Entity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Author { get; set; }

        [MaxLength(350)]
        public string Description { get; set; }

        public double Value { get; set; }

        public DateTime PublishDate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
