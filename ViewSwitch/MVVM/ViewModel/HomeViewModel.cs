using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewSwitch.Core;
using ViewSwitch.Services;

namespace ViewSwitch.MVVM.ViewModel
{
    public class HomeViewModel : Core.ViewModel
    {
        private INavigationService _navigation;
        public INavigationService Navigation
        {
            get => _navigation; set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateToSettingsViewCommand {  get; set; }

        public HomeViewModel(INavigationService navigation)
        {
            Navigation = navigation;
            NavigateToSettingsViewCommand = new RelayCommand(execute: (object o) => { Navigation.NavigateTo<SettingsViewModel>(); }, canExecute: (object o) => true);
        }
    }
}
