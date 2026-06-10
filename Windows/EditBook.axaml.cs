using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Libraria.Data;
using Libraria.Stuff;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Libraria;

public partial class EditBook : Window
{
    public EditBook()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (EditBookBox.Text == null || EditBookBox.Text.Length == 0)
        {
            EditBookBox.Watermark = "What do you want to edit?";
        }
        else
        {
            LibraryContext context = new LibraryContext();

            //тут использовал ии на проверку наличия книги в бд
            bool IsExists = context.books.Any(x => x.Title == EditBookBox.Text);

            if (IsExists)
            {
                TitleEdit.IsVisible = true;
                AuthorEdit.IsVisible = true;
                YearEdit.IsVisible = true;
                GenreEdit.IsVisible = true;
                EditButton.IsVisible = true;

                foreach (var item in context.books)
                {
                    if (item.Title == EditBookBox.Text)
                    {
                        TitleEdit.Text = item.Title;
                        AuthorEdit.Text = item.Author;
                        YearEdit.Text = item.YearPublished;
                        GenreEdit.Text = item.Genre;

                        break;
                    }
                }
            }
            else
            {
                EditBookBox.Text = null;
                EditBookBox.Watermark = "This book doesn't exist.";
            }
        }
    }

    private void EditButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        LibraryContext context = new LibraryContext();

        if (TitleEdit.Text.Length == 0 || AuthorEdit.Text.Length == 0 || YearEdit.Text.Length == 0 || GenreEdit.Text.Length == 0)
        {
            txt.Text = "What are you talking about?";
        }
        else
        {
            foreach (var item in context.books)
            {
                if (item.Title == EditBookBox.Text)
                {
                    item.Title = TitleEdit.Text;
                    item.Author = AuthorEdit.Text;
                    item.YearPublished = YearEdit.Text;
                    item.Genre = GenreEdit.Text;

                    break;
                }
            }

            context.SaveChanges();
            Hide();
        }
    }
}