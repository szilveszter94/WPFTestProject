using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace Header.ViewModels
{
    public class HeaderViewModel : BindableBase
    {
        public DelegateCommand ShowDialogCommand { get; }
        public DelegateCommand OpenImageCommand { get; set; }
        public string OpenImageButtonText { get { return _openImageButtonText; } set { _openImageButtonText = value; } }
        public string ProfileButtonText { get { return _profileButtonText; } set { _profileButtonText = value; } }

        private string _openImageButtonText = "Kép megnyitása";
        private string _profileButtonText = "Névjegy";
        private readonly IDialogService _dialogService;
        private readonly IRegionManager _regionManager;

        
        public HeaderViewModel(IDialogService dialogService, IRegionManager regionManager)
        {
            ShowDialogCommand = new DelegateCommand(ShowDialog);
            OpenImageCommand = new DelegateCommand(Navigate);
            _dialogService = dialogService;
            _regionManager = regionManager;
        }

        private void Navigate()
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.bmp;*.png;)|*.jpg;*.bmp;*.png;";

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                string selectedImagePath = openFileDialog.FileName;
                var parameters = new NavigationParameters();
                parameters.Add("visibility", "visible");
                parameters.Add("imgUrl", selectedImagePath);
                _regionManager.RequestNavigate("right_side", "RightSideView", parameters);
                _regionManager.RequestNavigate("left_side", "LeftSideView", parameters);
            }
        }

        private void ShowDialog()
        {
            _dialogService.ShowDialog("MessageDialog");
        }

    }
}
