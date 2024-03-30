using Prism.Mvvm;

namespace Header.ViewModels
{
    public class HeaderViewModel : BindableBase
    {
        private string _openImageButtonText = "Kép megnyitása";
        private string _profileButtonText = "Névjegy";

        public string OpenImageButtonText { get { return _openImageButtonText; } set { _openImageButtonText = value; } }
        public string ProfileButtonText { get { return _profileButtonText; } set { _profileButtonText = value; } }
    }
}
