using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgGame2025.Commands;
using System.Windows.Input;

namespace RpgGame2025.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public ICommand UpdateViewCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
