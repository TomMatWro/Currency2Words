using Currency2Words.ViewModels;
using Microsoft.Practices.Unity;

namespace Currency2Words
{
    public class ViewModelLocator
    {
        private IUnityContainer container;

        public ViewModelLocator()
        {
            container = new UnityContainer();
            ContainerBuilder.Configure(container);
        }

        public ConverterViewModel Main
        {
            get { return container.Resolve<ConverterViewModel>(); }
        }
    }
}
