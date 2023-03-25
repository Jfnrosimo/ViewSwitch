using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewSwitch.Core;
using ViewSwitch.Services;

namespace ViewSwitch.MVVM.ViewModel
{
    public class MainViewModel : Core.ViewModel
    {
        private INavigationService _navigation;

        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateToHomeCommand { get; set; }
        public RelayCommand NavigateToSettingsViewCommand { get; set; }


        public MainViewModel(INavigationService navService)
        {
            Navigation = navService;
            NavigateToHomeCommand = new RelayCommand(execute: (object o) => { Navigation.NavigateTo<HomeViewModel>(); }, canExecute:(object o) => true);
            NavigateToSettingsViewCommand = new RelayCommand(execute: (object o) => { Navigation.NavigateTo<SettingsViewModel>(); }, canExecute:(object o) => true);
        }
    }
}
