using Currency2Words.Views;
using Microsoft.Practices.Unity;
using System.Windows;

namespace Currency2Words
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IUnityContainer container = new UnityContainer();
            ContainerBuilder.Configure(container);

            var window = container.Resolve<MainWindow>();
            window.Show();
        }
    }
}
