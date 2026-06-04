using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Stuff
{
    internal class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime YearPublished { get; set; }
        
        public Author Author { get; set; } = null!;
        public Genre Genre { get; set; } = null!;

        public enum Status { NotRead, ReadingInProcess, Read }
    }
}
