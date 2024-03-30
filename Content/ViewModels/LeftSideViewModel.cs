using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.ViewModels
{
    class LeftSideViewModel : BindableBase
    {
        private string? _date;
        private string? _imageVisibility = "Hidden";

        public string? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string? ImageVisibility
        {
            get { return _imageVisibility; }
            set { SetProperty(ref _imageVisibility, value); }
        }

        public LeftSideViewModel()
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
