using Prism.Mvvm;
using Prism.Regions;

namespace Content.ViewModels
{
    class RightSideViewModel : BindableBase, INavigationAware
    {
        private string? _imgUrl;
        private string? _imageVisibility = "Hidden";

        public string? ImageVisibility
        {
            get { return _imageVisibility; }
            set { SetProperty(ref _imageVisibility, value); }
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
                if (navigationContext.Parameters.ContainsKey("visibility"))
                {
                    ImageVisibility = navigationContext.Parameters.GetValue<string>("visibility");
                }
            }
        }
    }
}
