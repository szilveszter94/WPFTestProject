using Prism.Mvvm;
using Prism.Regions;

namespace Content.ViewModels
{
    class RightSideViewModel : BindableBase
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
    }
}
