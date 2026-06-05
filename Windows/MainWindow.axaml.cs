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
    }
}