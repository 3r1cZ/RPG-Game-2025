using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame2025.ViewModels
{
    public class MenuViewModel : ViewViewModel
    {
        public MenuViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            UpdateViewCommand = MainViewModel.UpdateViewCommand;
        }
    }
}
