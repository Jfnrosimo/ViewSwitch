﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewSwitch.Core
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(sender:this, e:new PropertyChangedEventArgs(propertyName));
        }
    }
}
