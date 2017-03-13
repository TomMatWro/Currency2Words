using Currency2Words.ViewModels;
using Microsoft.Practices.Unity;

namespace Currency2Words.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        [Dependency]
        public IConverterViewModel ViewModel { get; set; }

        public MainWindow(IConverterViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }
    }
}
