using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfBlazorHybridApp.ViewModel;

namespace WpfBlazorHybridApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var serviceProvider = this.FindResource("ServiceProvider") as ServiceProvider;
            DataContext = serviceProvider?.GetService<MainViewModel>();
        }
    }
}