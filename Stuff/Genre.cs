using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Stuff
{
    internal class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
