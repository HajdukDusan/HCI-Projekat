using HCI_Projekat.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat.MvM.ViewModel
{
    class MainViewModel : ObservableObjects
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand UserProfileViewCommand { get; set; }

        public RelayCommand AllEventsViewCommand { get; set; }


        private object _currentView;
        public HomeViewModel HomeVm { get; set; }
        public UserProfileViewModel UserVm { get; set; }

        public AllEventsViewModel EventsVm { get; set; }


        public object CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            UserVm = new UserProfileViewModel();
            EventsVm = new AllEventsViewModel();
            CurrentView = HomeVm;
            HomeViewCommand = new RelayCommand(o => {
                CurrentView = HomeVm;
            });
            UserProfileViewCommand = new RelayCommand(o => {
                CurrentView = UserVm;
            });
            AllEventsViewCommand = new RelayCommand(o => {
                CurrentView = EventsVm;
            });
        }


    }
}
