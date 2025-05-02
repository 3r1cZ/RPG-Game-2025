using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame2025.ViewModels
{
    public class SaveFilesViewModel : ViewViewModel
    {
        public List<string> Files { get; set; }

        public SaveFilesViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;

            Files = new List<string>(6);
        }
    }
}
