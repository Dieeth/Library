using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Stuff
{
    internal class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        public ICollection<Book> Books { get; set; } = null!;
    }
}
