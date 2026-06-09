using Avalonia.Controls;
using Avalonia.Interactivity;
using Libraria.Data;
using Libraria.Stuff;
using System;
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
            if (TitleBox.Text == null || YearPublishedBox.Text == null || AuthorBox.Text == null || GenreBox.Text == null)
            {
                Reminder.Text = "All text poles should be filled.";

                TitleBox.Text = null;
                YearPublishedBox.Text = null;
                AuthorBox.Text = null;
                GenreBox.Text = null;
            }
            else
            {
                LibraryContext context = new LibraryContext();

                context.books.Add(new Book(TitleBox.Text, YearPublishedBox.Text, AuthorBox.Text, GenreBox.Text));
                context.SaveChanges();

                TitleBox.Text = null;
                YearPublishedBox.Text = null;
                AuthorBox.Text = null;
                GenreBox.Text = null;


            }
        }
    }
}

