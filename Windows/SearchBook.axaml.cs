using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Libraria.Data;

namespace Libraria;

public partial class SearchBook : Window
{
    public SearchBook()
    {
        InitializeComponent();
    }

    private void SearchByName(object? sender, RoutedEventArgs e)
    {
        if (Browser.Text == null)
        {
            Title.Text = "What do you want?";
        }
        else
        {
            LibraryContext context = new LibraryContext();
            Results.Children.Clear();

            foreach (var item in context.books)
            {
                if (item.Title == Browser.Text)
                {
                    var book = new TextBlock
                    {
                        Text = $"{item.Title} - {item.Author} - {item.YearPublished} - {item.Genre}"
                    };
                    Results.Children.Add(book);
                }
            }
        }
    }
    private void SearchByAuthor(object? sender, RoutedEventArgs e)
    {
        if (Browser.Text == null)
        {
            Title.Text = "What do you want?";
        }
        else
        {
            LibraryContext context = new LibraryContext();
            Results.Children.Clear();

            foreach (var item in context.books)
            {
                if (item.Author == Browser.Text)
                {
                    var book = new TextBlock
                    {
                        Text = $"{item.Title} - {item.Author} - {item.YearPublished} - {item.Genre} - {item}"
                    };
                    Results.Children.Add(book);
                }
            }
        }
    }
    private void SearchByReleaseYear(object? sender, RoutedEventArgs e)
    {
        if (Browser.Text == null)
        {
            Title.Text = "What do you want?";
        }
        else
        {
            LibraryContext context = new LibraryContext();
            Results.Children.Clear();

            foreach (var item in context.books)
            {
                if (item.YearPublished == Browser.Text)
                {
                    var book = new TextBlock
                    {
                        Text = $"{item.Title} - {item.Author} - {item.YearPublished} - {item.Genre}"
                    };
                    Results.Children.Add(book);
                }
            }
        }
    }
    private void SearchByGenre(object? sender, RoutedEventArgs e)
    {
        if (Browser.Text == null)
        {
            Title.Text = "What do you want?";
        }
        else
        {
            LibraryContext context = new LibraryContext();
            Results.Children.Clear();

            foreach (var item in context.books)
            {
                if (item.Genre == Browser.Text)
                {
                    var book = new TextBlock
                    {
                        Text = $"{item.Title} - {item.Author} - {item.YearPublished} - {item.Genre}"
                    };
                    Results.Children.Add(book);
                }
            }
        }
    }
}