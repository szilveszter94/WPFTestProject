﻿using Content.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Content
{
    public class ContentModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ContentModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("left_side", typeof(LeftSideView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LeftSideView>();
            containerRegistry.RegisterForNavigation<RightSideView>();
        }
    }
}
