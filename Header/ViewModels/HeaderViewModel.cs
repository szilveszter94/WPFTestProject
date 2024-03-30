using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace Header.ViewModels
{
    public class HeaderViewModel : BindableBase
    {
        public DelegateCommand ShowDialogCommand { get; }
        public string OpenImageButtonText { get { return _openImageButtonText; } set { _openImageButtonText = value; } }
        public string ProfileButtonText { get { return _profileButtonText; } set { _profileButtonText = value; } }

        private string _openImageButtonText = "Kép megnyitása";
        private string _profileButtonText = "Névjegy";
        private readonly IDialogService _dialogService;

        
        public HeaderViewModel(IDialogService dialogService)
        {
            ShowDialogCommand = new DelegateCommand(ShowDialog);
            _dialogService = dialogService;
        }

        private void ShowDialog()
        {
            _dialogService.ShowDialog("MessageDialog");
        }

    }
}
