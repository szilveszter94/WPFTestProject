using Prism.Mvvm;
using Prism.Regions;

namespace Footer.ViewModels
{
    class FooterViewModel : BindableBase, INavigationAware
    {
        private string? _imgUrl;
        private readonly IRegionManager _regionManager;

        public FooterViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public string? ImageUrl
        {
            get { return _imgUrl; }
            set { SetProperty(ref _imgUrl, value); }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters.ContainsKey("imgUrl"))
            {
                ImageUrl = navigationContext.Parameters.GetValue<string>("imgUrl");
            }
        }
    }
}
