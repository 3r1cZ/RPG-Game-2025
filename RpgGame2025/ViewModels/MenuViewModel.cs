using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgGame2025.Commands;

namespace RpgGame2025.ViewModels
{
    public class MenuViewModel : ViewViewModel
    {
        public MenuViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            UpdateViewCommand = new UpdateViewCommand(MainViewModel);
        }
    }
}
