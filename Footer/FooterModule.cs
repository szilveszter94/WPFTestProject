using Footer.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Footer
{
    public class FooterModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<FooterView>();
        }
    }
}
