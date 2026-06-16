using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Libraria.Data;
using Libraria.Stuff;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Libraria;

public partial class AllBooks : Window
{
    public AllBooks()
    {
        InitializeComponent();

        LibraryContext context = new LibraryContext();
        AllBooksPole.Children.Clear();

        foreach (var item in context.books)
        {
            var book = new TextBlock
            {
                Text = $"{item.Title} - {item.Author} - {item.YearPublished} - {item.Genre}"
            };
            AllBooksPole.Children.Add(book);
        }
    }

    private void NoSort(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        LibraryContext context = new LibraryContext();
        AllBooksPole.Children.Clear();

        foreach (var item in context.books)
        {
            var book = new TextBlock
            {
                Text = $"{item.Title} - {item.Author} - {item.YearPublished} - {item.Genre}"
            };
            AllBooksPole.Children.Add(book);
        }
    }

    private void RecentBooks(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        AllBooksPole.Children.Clear();
        LibraryContext context = new LibraryContext();
        
        List<Book> SortedByRecent = context.books.OrderByDescending(x => x.YearPublished).ToList();

        foreach (var item in SortedByRecent)
        {
            var book = new TextBlock
            {
                Text = $"{item.Title} - {item.Author} - {item.YearPublished} - {item.Genre}"
            };
            AllBooksPole.Children.Add(book);
        }
    }

    private void OldestBooks(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        AllBooksPole.Children.Clear();
        LibraryContext context = new LibraryContext();

        List<Book> SortedByOldest = context.books.OrderBy(x => x.YearPublished).ToList();

        foreach (var item in SortedByOldest)
        {
            var book = new TextBlock
            {
                Text = $"{item.Title} - {item.Author} - {item.YearPublished} - {item.Genre}"
            };
            AllBooksPole.Children.Add(book);
        }
    }

    private void AlphabetSort(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        AllBooksPole.Children.Clear();
        LibraryContext context = new LibraryContext();

        List<Book> SortedByAlphabet = context.books.OrderBy(x => x.Title).ToList();

        foreach (var item in SortedByAlphabet)
        {
            var book = new TextBlock
            {
                Text = $"{item.Title} - {item.Author} - {item.YearPublished} - {item.Genre}"
            };
            AllBooksPole.Children.Add(book);
        }
    }
}