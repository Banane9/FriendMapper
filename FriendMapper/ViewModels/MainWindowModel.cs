using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FriendMapper.ViewModels
{
    public sealed class MainWindowViewModel : INotifyPropertyChanged
    {
        public MapMode MapMode
        {
            get { return new AerialMode(true); }
        }

        #region PropertyChanged

        private void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null && propertyName != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion PropertyChanged
    }
}