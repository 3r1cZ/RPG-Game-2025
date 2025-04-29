using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame2025
{
    class MainViewModel : BaseNotificationClass
    {
        private object _currentView;

        public MenuViewModel MenuVm { get; set; }
        public SettingsViewModel SettingsVm { get; set; }

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public MainViewModel()
        {
            MenuVm = new MenuViewModel();
            SettingsVm = new SettingsViewModel();

            CurrentView = SettingsVm;
        }
    }
}
