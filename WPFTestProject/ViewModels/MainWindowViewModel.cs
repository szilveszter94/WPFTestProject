using Prism.Mvvm;

namespace WPFTestProject.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "WPF Tesztfeladat";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
