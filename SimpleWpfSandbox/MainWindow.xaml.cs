using SimpleWpfSandbox.ViewModels;
using System.Windows;
using MahApps.Metro.Controls;

namespace SimpleWpfSandbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel)?.DoButtonStuff();
        }
    }
}
