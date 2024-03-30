using Header.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Header
{
    public class HeaderModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public HeaderModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("header", typeof(HeaderView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
