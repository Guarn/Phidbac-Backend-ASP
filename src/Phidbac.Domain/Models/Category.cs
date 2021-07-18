using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phidbac.Domain.Models
{
    public class Category : Entity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        /* EF Relations */
        public IEnumerable<Book> Books { get; set; }
    }
}
