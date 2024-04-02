using System.Timers;
using Prism.Mvvm;
using Prism.Regions;

namespace Content.ViewModels
{
    class LeftSideViewModel : BindableBase, INavigationAware
    {
        private string? _date;
        private string? _imageVisibility = "Hidden";
        private System.Timers.Timer _timer;

        public string? Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        public string? ImageVisibility
        {
            get { return _imageVisibility; }
            set { SetProperty(ref _imageVisibility, value); }
        }

        public LeftSideViewModel()
        {
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;
            
            UpdateDate();
        }
        
        private void UpdateDate()
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            UpdateDate();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters.ContainsKey("visibility"))
            {
                ImageVisibility = navigationContext.Parameters.GetValue<string>("visibility");
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
