using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace HCI_Projekat.Core
{
    class ObservableObjects : INotifyPropertyChanged //update UI za binding
    {
        public event PropertyChangedEventHandler PropertyChanged; //event

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
