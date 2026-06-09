using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Security.Cryptography.X509Certificates;

namespace Libraria
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddWindow(object? sender, RoutedEventArgs e)
        {
            var AddBookWindow = new AddBook();

            AddBookWindow.Show();
        }
        private void SearchWindow(object? sender, RoutedEventArgs e)
        {
            var SearchBookWindow = new SearchBook();

            SearchBookWindow.Show();
        }
        private void DeleteWindow(object? sender, RoutedEventArgs e)
        {
            var DeleteBookWindow = new DeleteBook();

            DeleteBookWindow.Show();
        }

        private void EditWindow(object? sender, RoutedEventArgs e)
        {
            var EditBookWindow = new EditBook();

            EditBookWindow.Show();
        }
    }
}