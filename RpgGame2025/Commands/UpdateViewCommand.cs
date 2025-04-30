using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RpgGame2025.ViewModels;

namespace RpgGame2025.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel _viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch(parameter.ToString())
            {
                case "Menu":
                    _viewModel.CurrentViewModel = new MenuViewModel();
                    return;

                case "Settings":
                    _viewModel.CurrentViewModel = new SettingsViewModel();
                    return;

                default:
                    return;
            }
        }
    }
}
