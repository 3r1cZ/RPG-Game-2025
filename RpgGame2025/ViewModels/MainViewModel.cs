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
        private ViewViewModel _currentViewModel;
        public ViewViewModel CurrentViewModel
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
        /// Keybind properties
        /// </summary>
        private string _keybindMoveUp = "w";
        public string KeybindMoveUp
        {
            get => _keybindMoveUp;
            set
            {
                _keybindMoveUp = value;
                DebugTools.Debug("Keybind move up", _keybindMoveUp);
                OnPropertyChanged(nameof(KeybindMoveUp));
            }
        }
        private string _keybindMoveLeft = "a";
        public string KeybindMoveLeft
        {
            get => _keybindMoveLeft;
            set
            {
                _keybindMoveLeft = value;
                DebugTools.Debug("Keybind move left", _keybindMoveLeft);
                OnPropertyChanged(nameof(KeybindMoveLeft));
            }
        }
        private string _keybindMoveDown = "s";
        public string KeybindMoveDown
        {
            get => _keybindMoveDown;
            set
            {
                _keybindMoveDown = value;
                DebugTools.Debug("Keybind move down", _keybindMoveDown);
                OnPropertyChanged(nameof(KeybindMoveDown));
            }
        }
        private string _keybindMoveRight = "d";
        public string KeybindMoveRight
        {
            get => _keybindMoveRight;
            set
            {
                _keybindMoveRight = value;
                DebugTools.Debug("Keybind move right", _keybindMoveRight);
                OnPropertyChanged(nameof(KeybindMoveRight));
            }
        }
        private string _keybindDash = "space";
        public string KeybindDash
        {
            get => _keybindDash;
            set
            {
                _keybindDash = value;
                DebugTools.Debug("Keybind dash", _keybindDash);
                OnPropertyChanged(nameof(KeybindDash));
            }
        }
        private string _keybindAttack = "left mouse button";
        public string KeybindAttack
        {
            get => _keybindAttack;
            set
            {
                _keybindAttack = value;
                DebugTools.Debug("Keybind attack", _keybindAttack);
                OnPropertyChanged(nameof(KeybindAttack));
            }
        }
        private string _keybindOffhand = "right mouse button";
        public string KeybindOffhand
        {
            get => _keybindOffhand;
            set
            {
                _keybindOffhand = value;
                DebugTools.Debug("Keybind offhand", _keybindOffhand);
                OnPropertyChanged(nameof(KeybindOffhand));
            }
        }


        /// <summary>
        /// MainViewModel constructor
        /// </summary>
        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);

            _currentViewModel = new MenuViewModel(this);
        }
    }
}
