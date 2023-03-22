using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewSwitch.Core;

namespace ViewSwitch.Services
{

    public interface INavigationService
    {
        ViewModel CurrentView { get; }

        void NavigateTo<T>() where T : ViewModel;
    }
    public class NavigationService : ObservableObject, INavigationService
    {
        private ViewModel _currentView;

        public ViewModel CurrentView {
            get => _currentView;
            private set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public void NavigateTo<T>() where T : ViewModel
        {
            throw new NotImplementedException();
        }
    }
}
