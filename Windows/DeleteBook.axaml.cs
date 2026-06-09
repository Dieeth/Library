using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Libraria.Data;

namespace Libraria;

public partial class DeleteBook : Window
{
    public DeleteBook()
    {
        InitializeComponent();
    }

    private void EnsureDeletion(object? sender, RoutedEventArgs e)
    {
        if (Textbox.Text == null || Textbox.Text == "")
        {
            Textbox.Watermark = "You should fill this box.";
        }
        else
        {
            a.IsVisible = true; a.IsEnabled = true;
            b.IsVisible = true; b.IsEnabled = true;
            c.IsVisible = true; c.IsEnabled = true;
        }
    }

    private void Delete(object? sender, RoutedEventArgs e)
    {
        LibraryContext context = new LibraryContext();

        if (Textbox.Text == null || Textbox.Text == "")
        {
            Textbox.Watermark = "You should fill this box.";
        }
        else
        {
            foreach (var item in context.books)
            {
                if (item.Title == Textbox.Text)
                {
                    context.books.Remove(item);
                }
            }

            context.SaveChanges();
            Hide();
        }
    }

    private void Escape(object? sender, RoutedEventArgs e)
    {
        Hide();
    }
}