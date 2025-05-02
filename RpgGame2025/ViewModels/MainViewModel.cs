using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RpgGame2025.Commands;

namespace RpgGame2025.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Viewmodel properties
        /// </summary>
        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                DebugTools.Debug("Current Viewmodel", _currentViewModel.GetType().ToString());
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }


        /// <summary>
        /// Volume properties
        /// </summary>
        private int _masterVolume = 100;
        public int MasterVolume
        {
            get => _masterVolume;
            set 
            {
                _masterVolume = value;
                DebugTools.Debug("Master volume", _masterVolume.ToString());
                OnPropertyChanged(nameof(MasterVolume));
            }
        }


        /// <summary>
        /// MainViewModel constructor
        /// </summary>
        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
