using Libraria.Stuff;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Data
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Author> authors { get; set; } = null!;
        public DbSet<Book> books { get; set; } = null!;
        public DbSet<Genre> genres { get; set; } = null!; 

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
              Server=(localdb)\mssqllocaldb;
              Database=LibraryDB;
              Integrated Security=True;
              TrustServerCertificate=True;");
        }
    }
}
