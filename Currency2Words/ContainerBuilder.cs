using Currency2Words.ViewModels;
using Microsoft.Practices.Unity;

namespace Currency2Words
{
    public static class ContainerBuilder
    {
        public static void Configure(IUnityContainer container)
        {
            container.RegisterType<IConverterViewModel, ConverterViewModel>(new ContainerControlledLifetimeManager());
        }
    }
}