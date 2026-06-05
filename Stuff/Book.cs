using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Stuff
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string YearPublished { get; set; }
        public string Author { get; set; } = null!;
        public string Genre { get; set; } = null!;

        public enum Status { NotRead, ReadingInProcess, Read }

        public Book(string title, string yearpublished, string author, string genre)
        {
            Title = title;
            YearPublished = yearpublished;
            Author = author;
            Genre = genre;
        }
        public Book() { }
    }
}
