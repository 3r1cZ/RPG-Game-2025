using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RpgGame2025.Commands;

namespace RpgGame2025.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public MainViewModel MainViewModel { get; set; }

        public SettingsViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            UpdateViewCommand = new UpdateViewCommand(MainViewModel);
        }

    }
}
