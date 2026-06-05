using Avalonia.Controls;
using Avalonia.Interactivity;
using Libraria.Data;
using Libraria.Stuff;
using System.Security.Cryptography.X509Certificates;

namespace Libraria 
{
    public partial class AddBook : Window
    {
        public AddBook()
        {
            InitializeComponent();
        }
        private void NewBook(object? sender, RoutedEventArgs e)
        {
            LibraryContext context = new LibraryContext();

            context.books.Add(new Book(TitleBox.Text, YearPublishedBox.Text, AuthorBox.Text, GenreBox.Text));
            context.SaveChanges();
        }
    }
}

